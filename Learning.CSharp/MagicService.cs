using System;

namespace Learning.CSharp
{
    static class MagicService
    {
        private static bool LogException(Exception ex)
        {
            return false;
        }

        public static bool CastSpell(string spell)
        {
            try
            {
                // 실행하고자 하는 작업들

                // 실패했다고 가정하고 예외를 강제로 발생시킵니다.
                throw new MagicServiceException("Spell failed", 42);

                // 예외가 강제로 발생하므로, 아래 <코드>는 수행되지 않습니다.
                // <코드>
            }
            // 조건에 맞는 예외만 잡아냅니다.
            catch (MagicServiceException ex) when (ex.Code == 42)
            {
                // try 블럭에서 예외가 발생하여 catch 문이 실행되었다면, 해당 예외는 이미 처리된 것으로 간주됩니다.
                // catch 문에서 throw를 다시 사용하면 (단, throw 문 다음에 예외 객체 없이, 'throw;' 만)
                // 이 예외를 발생시킨 콜스택 정보의 변경없이 상위호출자에게 전달할 수 있습니다.
                return false;
            }
            catch (Exception ex) when (LogException(ex))
            {
                // 모든 예외를 잡아내지만, LogException이 거짓을 반환하므로 이 부분은 실행되지 않습니다.
                // 모든 예외를 잡기 위해서는 catch {} 또는 catch (Exception ex) {} 처럼 사용하는데,
                // 이러한 방식의 예외처리는 절대 권장되지 않습니다. 
            }
            finally
            {
                // 이 부분은 예외의 발생여부와 상관없이 반드시 실행되는 코드 블록입니다.
                // 연결, 파일 오픈 등 예외에 상관없이 반드시 객체를 닫아야 할 경우에 사용됩니다.
            }
            return false;
        }
    }
}
