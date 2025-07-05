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

    public class InvoiceSealInfo : AbstractModel
    {
        
        /// <summary>
        /// 是否有公司印章（0：没有，1：有）
        /// </summary>
        [JsonProperty("CompanySealMark")]
        public string CompanySealMark{ get; set; }

        /// <summary>
        /// 是否有监制印章（0：没有，1：有）
        /// </summary>
        [JsonProperty("SupervisionSealMark")]
        public string SupervisionSealMark{ get; set; }

        /// <summary>
        /// 公司印章信息
        /// </summary>
        [JsonProperty("CompanySealMarkInfo")]
        public string[] CompanySealMarkInfo{ get; set; }

        /// <summary>
        /// 监制印章信息
        /// </summary>
        [JsonProperty("SupervisionSealMarkInfo")]
        public string[] SupervisionSealMarkInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CompanySealMark", this.CompanySealMark);
            this.SetParamSimple(map, prefix + "SupervisionSealMark", this.SupervisionSealMark);
            this.SetParamArraySimple(map, prefix + "CompanySealMarkInfo.", this.CompanySealMarkInfo);
            this.SetParamArraySimple(map, prefix + "SupervisionSealMarkInfo.", this.SupervisionSealMarkInfo);
        }
    }
}

