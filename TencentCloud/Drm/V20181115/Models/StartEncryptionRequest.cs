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

namespace TencentCloud.Drm.V20181115.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class StartEncryptionRequest : AbstractModel
    {
        
        /// <summary>
        /// cos的end point。
        /// </summary>
        [JsonProperty("CosEndPoint")]
        public string CosEndPoint{ get; set; }

        /// <summary>
        /// cos api密钥id。
        /// </summary>
        [JsonProperty("CosSecretId")]
        public string CosSecretId{ get; set; }

        /// <summary>
        /// cos api密钥。
        /// </summary>
        [JsonProperty("CosSecretKey")]
        public string CosSecretKey{ get; set; }

        /// <summary>
        /// 使用的DRM方案类型，接口取值WIDEVINE,FAIRPLAY
        /// </summary>
        [JsonProperty("DrmType")]
        public string DrmType{ get; set; }

        /// <summary>
        /// 存储在COS上的原始内容信息
        /// </summary>
        [JsonProperty("SourceObject")]
        public DrmSourceObject SourceObject{ get; set; }

        /// <summary>
        /// 加密后的内容存储到COS的对象
        /// </summary>
        [JsonProperty("OutputObjects")]
        public DrmOutputObject[] OutputObjects{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CosEndPoint", this.CosEndPoint);
            this.SetParamSimple(map, prefix + "CosSecretId", this.CosSecretId);
            this.SetParamSimple(map, prefix + "CosSecretKey", this.CosSecretKey);
            this.SetParamSimple(map, prefix + "DrmType", this.DrmType);
            this.SetParamObj(map, prefix + "SourceObject.", this.SourceObject);
            this.SetParamArrayObj(map, prefix + "OutputObjects.", this.OutputObjects);
        }
    }
}

