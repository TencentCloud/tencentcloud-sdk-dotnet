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

namespace TencentCloud.Cpdp.V20190820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UploadTaxPaymentRequest : AbstractModel
    {
        
        /// <summary>
        /// 平台渠道
        /// </summary>
        [JsonProperty("Channel")]
        public long? Channel{ get; set; }

        /// <summary>
        /// 完税ID
        /// </summary>
        [JsonProperty("TaxId")]
        public string TaxId{ get; set; }

        /// <summary>
        /// 完税列表下载地址
        /// </summary>
        [JsonProperty("FileUrl")]
        public string FileUrl{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Channel", this.Channel);
            this.SetParamSimple(map, prefix + "TaxId", this.TaxId);
            this.SetParamSimple(map, prefix + "FileUrl", this.FileUrl);
        }
    }
}

