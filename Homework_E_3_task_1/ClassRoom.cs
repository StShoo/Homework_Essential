using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_E_3_task_1
{
    class ClassRoom
    {
        Pupil firstStudent, secondStudent, thirdStudent, fourthStudent;
        public ClassRoom(Pupil firstStudent, Pupil secondStudent, Pupil thirdStudent, Pupil fourthStudent)
        {
            this.firstStudent = firstStudent;
            this.secondStudent = secondStudent;
            this.thirdStudent = thirdStudent;
            this.fourthStudent = fourthStudent;
        }

        public ClassRoom(Pupil firstStudent, Pupil secondStudent, Pupil thirdStudent)
        {
            this.firstStudent = firstStudent;
            this.secondStudent = secondStudent;
            this.thirdStudent = thirdStudent;
        }

        public ClassRoom(Pupil firstStudent, Pupil secondStudent)
        {
            this.firstStudent = firstStudent;
            this.secondStudent = secondStudent;
        }

        public Pupil FirstStudent
        {
            get
            {
                return firstStudent;
            }
        }
        public Pupil SecondStudent
        {
            get
            {
                return secondStudent;
            }
        }
        public Pupil ThirdStudent
        {
            get
            {
                return thirdStudent;
            }
        }
        public Pupil FourthStudent
        {
            get
            {
                return fourthStudent;
            }
        }

    }
    
}
