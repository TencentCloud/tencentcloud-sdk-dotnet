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

    public class PropOwnerCertOCRResponse : AbstractModel
    {
        
        /// <summary>
        /// 房地产权利人
        /// </summary>
        [JsonProperty("Owner")]
        public string Owner{ get; set; }

        /// <summary>
        /// 共有情况
        /// </summary>
        [JsonProperty("Possession")]
        public string Possession{ get; set; }

        /// <summary>
        /// 登记时间
        /// </summary>
        [JsonProperty("RegisterTime")]
        public string RegisterTime{ get; set; }

        /// <summary>
        /// 规划用途
        /// </summary>
        [JsonProperty("Purpose")]
        public string Purpose{ get; set; }

        /// <summary>
        /// 房屋性质
        /// </summary>
        [JsonProperty("Nature")]
        public string Nature{ get; set; }

        /// <summary>
        /// 房地坐落
        /// </summary>
        [JsonProperty("Location")]
        public string Location{ get; set; }

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
            this.SetParamSimple(map, prefix + "Owner", this.Owner);
            this.SetParamSimple(map, prefix + "Possession", this.Possession);
            this.SetParamSimple(map, prefix + "RegisterTime", this.RegisterTime);
            this.SetParamSimple(map, prefix + "Purpose", this.Purpose);
            this.SetParamSimple(map, prefix + "Nature", this.Nature);
            this.SetParamSimple(map, prefix + "Location", this.Location);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

