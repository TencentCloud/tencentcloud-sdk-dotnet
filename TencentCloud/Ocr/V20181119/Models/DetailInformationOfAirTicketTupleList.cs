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

    public class DetailInformationOfAirTicketTupleList : AbstractModel
    {
        
        /// <summary>
        /// 出发站（自）
        /// </summary>
        [JsonProperty("DepartureStation")]
        public string DepartureStation{ get; set; }

        /// <summary>
        /// 目的地（至）
        /// </summary>
        [JsonProperty("DestinationStation")]
        public string DestinationStation{ get; set; }

        /// <summary>
        /// 航班
        /// </summary>
        [JsonProperty("FlightSegment")]
        public string FlightSegment{ get; set; }

        /// <summary>
        /// 航班
        /// </summary>
        [JsonProperty("Carrier")]
        public string Carrier{ get; set; }

        /// <summary>
        /// 航班号
        /// </summary>
        [JsonProperty("Flight")]
        public string Flight{ get; set; }

        /// <summary>
        /// 座位等级
        /// </summary>
        [JsonProperty("SeatClass")]
        public string SeatClass{ get; set; }

        /// <summary>
        /// 日期
        /// </summary>
        [JsonProperty("CarrierDate")]
        public string CarrierDate{ get; set; }

        /// <summary>
        /// 时间
        /// </summary>
        [JsonProperty("DepartureTime")]
        public string DepartureTime{ get; set; }

        /// <summary>
        /// 客票级别/客票类别
        /// </summary>
        [JsonProperty("FareBasis")]
        public string FareBasis{ get; set; }

        /// <summary>
        /// 客票生效日期
        /// </summary>
        [JsonProperty("EffectiveDate")]
        public string EffectiveDate{ get; set; }

        /// <summary>
        /// 有效截止日期
        /// </summary>
        [JsonProperty("ExpirationDate")]
        public string ExpirationDate{ get; set; }

        /// <summary>
        /// 免费行李
        /// </summary>
        [JsonProperty("FreeBaggageAllowance")]
        public string FreeBaggageAllowance{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DepartureStation", this.DepartureStation);
            this.SetParamSimple(map, prefix + "DestinationStation", this.DestinationStation);
            this.SetParamSimple(map, prefix + "FlightSegment", this.FlightSegment);
            this.SetParamSimple(map, prefix + "Carrier", this.Carrier);
            this.SetParamSimple(map, prefix + "Flight", this.Flight);
            this.SetParamSimple(map, prefix + "SeatClass", this.SeatClass);
            this.SetParamSimple(map, prefix + "CarrierDate", this.CarrierDate);
            this.SetParamSimple(map, prefix + "DepartureTime", this.DepartureTime);
            this.SetParamSimple(map, prefix + "FareBasis", this.FareBasis);
            this.SetParamSimple(map, prefix + "EffectiveDate", this.EffectiveDate);
            this.SetParamSimple(map, prefix + "ExpirationDate", this.ExpirationDate);
            this.SetParamSimple(map, prefix + "FreeBaggageAllowance", this.FreeBaggageAllowance);
        }
    }
}

