/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

namespace TencentCloud.Ocr.V20181119.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class FlightItemInfo : AbstractModel
    {
        
        /// <summary>
        /// 出发站
        /// </summary>
        [JsonProperty("TerminalGetOn")]
        public string TerminalGetOn{ get; set; }

        /// <summary>
        /// 到达站
        /// </summary>
        [JsonProperty("TerminalGetOff")]
        public string TerminalGetOff{ get; set; }

        /// <summary>
        /// 承运人
        /// </summary>
        [JsonProperty("Carrier")]
        public string Carrier{ get; set; }

        /// <summary>
        /// 航班号
        /// </summary>
        [JsonProperty("FlightNumber")]
        public string FlightNumber{ get; set; }

        /// <summary>
        /// 座位等级
        /// </summary>
        [JsonProperty("Seat")]
        public string Seat{ get; set; }

        /// <summary>
        /// 乘机日期
        /// </summary>
        [JsonProperty("DateGetOn")]
        public string DateGetOn{ get; set; }

        /// <summary>
        /// 乘机时间
        /// </summary>
        [JsonProperty("TimeGetOn")]
        public string TimeGetOn{ get; set; }

        /// <summary>
        /// 客票级别/客票类别
        /// </summary>
        [JsonProperty("FareBasis")]
        public string FareBasis{ get; set; }

        /// <summary>
        /// 免费行李额
        /// </summary>
        [JsonProperty("Allow")]
        public string Allow{ get; set; }

        /// <summary>
        /// 客票生效日期
        /// </summary>
        [JsonProperty("DateStart")]
        public string DateStart{ get; set; }

        /// <summary>
        /// 有效截止日期
        /// </summary>
        [JsonProperty("DateEnd")]
        public string DateEnd{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TerminalGetOn", this.TerminalGetOn);
            this.SetParamSimple(map, prefix + "TerminalGetOff", this.TerminalGetOff);
            this.SetParamSimple(map, prefix + "Carrier", this.Carrier);
            this.SetParamSimple(map, prefix + "FlightNumber", this.FlightNumber);
            this.SetParamSimple(map, prefix + "Seat", this.Seat);
            this.SetParamSimple(map, prefix + "DateGetOn", this.DateGetOn);
            this.SetParamSimple(map, prefix + "TimeGetOn", this.TimeGetOn);
            this.SetParamSimple(map, prefix + "FareBasis", this.FareBasis);
            this.SetParamSimple(map, prefix + "Allow", this.Allow);
            this.SetParamSimple(map, prefix + "DateStart", this.DateStart);
            this.SetParamSimple(map, prefix + "DateEnd", this.DateEnd);
        }
    }
}

