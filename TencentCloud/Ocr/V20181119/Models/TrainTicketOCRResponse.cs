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

    public class TrainTicketOCRResponse : AbstractModel
    {
        
        /// <summary>
        /// 编号
        /// </summary>
        [JsonProperty("TicketNum")]
        public string TicketNum{ get; set; }

        /// <summary>
        /// 出发站
        /// </summary>
        [JsonProperty("StartStation")]
        public string StartStation{ get; set; }

        /// <summary>
        /// 到达站
        /// </summary>
        [JsonProperty("DestinationStation")]
        public string DestinationStation{ get; set; }

        /// <summary>
        /// 出发时间
        /// </summary>
        [JsonProperty("Date")]
        public string Date{ get; set; }

        /// <summary>
        /// 车次
        /// </summary>
        [JsonProperty("TrainNum")]
        public string TrainNum{ get; set; }

        /// <summary>
        /// 座位号
        /// </summary>
        [JsonProperty("Seat")]
        public string Seat{ get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 票价
        /// </summary>
        [JsonProperty("Price")]
        public string Price{ get; set; }

        /// <summary>
        /// 席别
        /// </summary>
        [JsonProperty("SeatCategory")]
        public string SeatCategory{ get; set; }

        /// <summary>
        /// 身份证号
        /// </summary>
        [JsonProperty("ID")]
        public string ID{ get; set; }

        /// <summary>
        /// 发票消费类型
        /// </summary>
        [JsonProperty("InvoiceType")]
        public string InvoiceType{ get; set; }

        /// <summary>
        /// 序列号
        /// </summary>
        [JsonProperty("SerialNumber")]
        public string SerialNumber{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TicketNum", this.TicketNum);
            this.SetParamSimple(map, prefix + "StartStation", this.StartStation);
            this.SetParamSimple(map, prefix + "DestinationStation", this.DestinationStation);
            this.SetParamSimple(map, prefix + "Date", this.Date);
            this.SetParamSimple(map, prefix + "TrainNum", this.TrainNum);
            this.SetParamSimple(map, prefix + "Seat", this.Seat);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Price", this.Price);
            this.SetParamSimple(map, prefix + "SeatCategory", this.SeatCategory);
            this.SetParamSimple(map, prefix + "ID", this.ID);
            this.SetParamSimple(map, prefix + "InvoiceType", this.InvoiceType);
            this.SetParamSimple(map, prefix + "SerialNumber", this.SerialNumber);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

