/*
 * Copyright (c) 2018-2025 Tencent. All Rights Reserved.
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

    public class TaxiTicket : AbstractModel
    {
        
        /// <summary>
        /// 发票名称
        /// </summary>
        [JsonProperty("Title")]
        public string Title{ get; set; }

        /// <summary>
        /// 是否存在二维码（1：有，0：无）
        /// </summary>
        [JsonProperty("QRCodeMark")]
        public long? QRCodeMark{ get; set; }

        /// <summary>
        /// 发票代码
        /// </summary>
        [JsonProperty("Code")]
        public string Code{ get; set; }

        /// <summary>
        /// 发票号码
        /// </summary>
        [JsonProperty("Number")]
        public string Number{ get; set; }

        /// <summary>
        /// 开票日期
        /// </summary>
        [JsonProperty("Date")]
        public string Date{ get; set; }

        /// <summary>
        /// 上车时间
        /// </summary>
        [JsonProperty("TimeGetOn")]
        public string TimeGetOn{ get; set; }

        /// <summary>
        /// 下车时间
        /// </summary>
        [JsonProperty("TimeGetOff")]
        public string TimeGetOff{ get; set; }

        /// <summary>
        /// 单价
        /// </summary>
        [JsonProperty("Price")]
        public string Price{ get; set; }

        /// <summary>
        /// 里程
        /// </summary>
        [JsonProperty("Mileage")]
        public string Mileage{ get; set; }

        /// <summary>
        /// 总金额
        /// </summary>
        [JsonProperty("Total")]
        public string Total{ get; set; }

        /// <summary>
        /// 发票所在地
        /// </summary>
        [JsonProperty("Place")]
        public string Place{ get; set; }

        /// <summary>
        /// 省
        /// </summary>
        [JsonProperty("Province")]
        public string Province{ get; set; }

        /// <summary>
        /// 市
        /// </summary>
        [JsonProperty("City")]
        public string City{ get; set; }

        /// <summary>
        /// 发票消费类型
        /// </summary>
        [JsonProperty("Kind")]
        public string Kind{ get; set; }

        /// <summary>
        /// 车牌号
        /// </summary>
        [JsonProperty("LicensePlate")]
        public string LicensePlate{ get; set; }

        /// <summary>
        /// 燃油附加费
        /// </summary>
        [JsonProperty("FuelFee")]
        public string FuelFee{ get; set; }

        /// <summary>
        /// 预约叫车服务费
        /// </summary>
        [JsonProperty("BookingCallFee")]
        public string BookingCallFee{ get; set; }

        /// <summary>
        /// 是否有公司印章（0：没有，1：有）
        /// </summary>
        [JsonProperty("CompanySealMark")]
        public long? CompanySealMark{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Title", this.Title);
            this.SetParamSimple(map, prefix + "QRCodeMark", this.QRCodeMark);
            this.SetParamSimple(map, prefix + "Code", this.Code);
            this.SetParamSimple(map, prefix + "Number", this.Number);
            this.SetParamSimple(map, prefix + "Date", this.Date);
            this.SetParamSimple(map, prefix + "TimeGetOn", this.TimeGetOn);
            this.SetParamSimple(map, prefix + "TimeGetOff", this.TimeGetOff);
            this.SetParamSimple(map, prefix + "Price", this.Price);
            this.SetParamSimple(map, prefix + "Mileage", this.Mileage);
            this.SetParamSimple(map, prefix + "Total", this.Total);
            this.SetParamSimple(map, prefix + "Place", this.Place);
            this.SetParamSimple(map, prefix + "Province", this.Province);
            this.SetParamSimple(map, prefix + "City", this.City);
            this.SetParamSimple(map, prefix + "Kind", this.Kind);
            this.SetParamSimple(map, prefix + "LicensePlate", this.LicensePlate);
            this.SetParamSimple(map, prefix + "FuelFee", this.FuelFee);
            this.SetParamSimple(map, prefix + "BookingCallFee", this.BookingCallFee);
            this.SetParamSimple(map, prefix + "CompanySealMark", this.CompanySealMark);
        }
    }
}

