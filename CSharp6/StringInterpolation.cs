using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp6
{
    class StringInterpolation
    {
        public void OldSample()
        {
            string siteName = "블로그";
            string userName = "방문자";
            bool isFirstVisit = true;
            int visitorCount = 20;
            float ratio = 0.3F;

            string formatResult = string.Format("{0}님 {1}에 오신것을 환영합니다.{2}", userName, siteName, isFirstVisit ? " 처음 방문해 주셨네요": "");
            string concatResult = userName + "님 " + siteName + "에 오신것을 환영합니다." + (isFirstVisit ? " 처음 방문해 주셨네요" : "");
            string visitorMessage = string.Format("{0,5}분이 현재 접속 중이며, 현재 점수 가중치는 {1,5:F2}입니다.", visitorCount, ratio);

            Console.WriteLine(formatResult);
            Console.WriteLine(concatResult);
            Console.WriteLine(visitorMessage);
            // 방문자님 블로그에 오신것을 환영합니다. 처음 방문해 주셨네요
            // 방문자님 블로그에 오신것을 환영합니다. 처음 방문해 주셨네요
            //    20분이 현재 접속 중이며, 현재 점수 가중치는  0.30입니다.
        }

        public void Interpolation()
        {
            string siteName = "블로그";
            string userName = "방문자";
            bool isFirstVisit = true;
            int visitorCount = 20;
            float ratio = 0.3F;

            string result = $"{userName}님 {siteName}에 오신것을 환영합니다.{(isFirstVisit ? " 처음 방문해 주셨네요" : "")}";
            string visitorMessage = $"{visitorCount,5}분이 현재 접속 중이며, 현재 점수 가중치는 {ratio,5:F2}입니다.";

            Console.WriteLine(result);
            Console.WriteLine(visitorMessage);

            // 방문자님 블로그에 오신것을 환영합니다. 처음 방문해 주셨네요
            //    20분이 현재 접속 중이며, 현재 점수 가중치는  0.30입니다.
        }
    }
}
