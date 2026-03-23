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

    public class TextWaybill : AbstractModel
    {
        
        /// <summary>
        /// <p>收件人姓名</p>
        /// </summary>
        [JsonProperty("RecName")]
        public WaybillObj RecName{ get; set; }

        /// <summary>
        /// <p>收件人手机号</p>
        /// </summary>
        [JsonProperty("RecNum")]
        public WaybillObj RecNum{ get; set; }

        /// <summary>
        /// <p>收件人地址</p>
        /// </summary>
        [JsonProperty("RecAddr")]
        public WaybillObj RecAddr{ get; set; }

        /// <summary>
        /// <p>寄件人姓名</p>
        /// </summary>
        [JsonProperty("SenderName")]
        public WaybillObj SenderName{ get; set; }

        /// <summary>
        /// <p>寄件人手机号</p>
        /// </summary>
        [JsonProperty("SenderNum")]
        public WaybillObj SenderNum{ get; set; }

        /// <summary>
        /// <p>寄件人地址</p>
        /// </summary>
        [JsonProperty("SenderAddr")]
        public WaybillObj SenderAddr{ get; set; }

        /// <summary>
        /// <p>运单号, 当同时存在 母 / 子 运单号时， 该字段为子运单号</p>
        /// </summary>
        [JsonProperty("WaybillNum")]
        public WaybillObj WaybillNum{ get; set; }

        /// <summary>
        /// <p>母运单号， 当不存在母运单号时， 该字段为不存在</p>
        /// </summary>
        [JsonProperty("MainWaybillNum")]
        public WaybillObj MainWaybillNum{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "RecName.", this.RecName);
            this.SetParamObj(map, prefix + "RecNum.", this.RecNum);
            this.SetParamObj(map, prefix + "RecAddr.", this.RecAddr);
            this.SetParamObj(map, prefix + "SenderName.", this.SenderName);
            this.SetParamObj(map, prefix + "SenderNum.", this.SenderNum);
            this.SetParamObj(map, prefix + "SenderAddr.", this.SenderAddr);
            this.SetParamObj(map, prefix + "WaybillNum.", this.WaybillNum);
            this.SetParamObj(map, prefix + "MainWaybillNum.", this.MainWaybillNum);
        }
    }
}

