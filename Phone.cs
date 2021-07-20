using System;
using System.Collections.Generic;
using System.Text;

namespace params__in_named_and_optional_args
{
    class Phone
    {
        public string screen_size;
        public string model;
        public int battery;
        public string camera_qulity;

        public Phone(string screen_size = "1000X1000", string model = "iphoneXs", int battery = 1000, string camera_qulity = "good")
        {
            this.screen_size = screen_size;
            this.model = model;
            this.battery = battery;
            this.camera_qulity = camera_qulity;
        }
    }
}
