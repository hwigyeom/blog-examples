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
            int visitorCount = 20;
            float ratio = 0.3F;

            string formatResult = string.Format("{0}님 {1}에 오신것을 환영합니다.", userName, siteName);
            string concatResult = userName + "님 " + siteName + "에 오신것을 환영합니다.";

            string visitorMessage = string.Format("{0,5}분이 현재 접속 중이며, 현재 점수 가중치는 {1,5:F2}입니다.", visitorCount, ratio);

            Console.WriteLine(visitorMessage);
        }

        public void Interpolation()
        {
            string siteName = "블로그";
            string userName = "방문자";
            int visitorCount = 20;
            float ratio = 0.3F;

            string result = $"{userName}님 {siteName}에 오신것을 환영합니다.";
            string visitorMessage = $"{visitorCount,5}분이 현재 접속 중이며, 현재 점수 가중치는 {ratio,5:F2}입니다.";

            Console.WriteLine(visitorMessage);
        }
    }
}
