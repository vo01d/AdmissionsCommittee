﻿namespace AdmissionsCommittee {
    class Subject {
        public int _id { get; set; }
        public string _name { get; set; }

        public Subject(int id, string name) {
            _id = id;
            _name = name;
        }
    }
}
