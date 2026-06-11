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

namespace TencentCloud.Tcr.V20190924.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModelDetail : AbstractModel
    {
        
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ModelName")]
        public string ModelName{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("NamespaceName")]
        public string NamespaceName{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("Version")]
        public string Version{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("Digest")]
        public string Digest{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("Size")]
        public long? Size{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("Framework")]
        public string Framework{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("Precision")]
        public string Precision{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("FileFormat")]
        public string FileFormat{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ParamSize")]
        public string ParamSize{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("Family")]
        public string Family{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("IsRecommended")]
        public bool? IsRecommended{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("PushTime")]
        public string PushTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ModelName", this.ModelName);
            this.SetParamSimple(map, prefix + "NamespaceName", this.NamespaceName);
            this.SetParamSimple(map, prefix + "Version", this.Version);
            this.SetParamSimple(map, prefix + "Digest", this.Digest);
            this.SetParamSimple(map, prefix + "Size", this.Size);
            this.SetParamSimple(map, prefix + "Framework", this.Framework);
            this.SetParamSimple(map, prefix + "Precision", this.Precision);
            this.SetParamSimple(map, prefix + "FileFormat", this.FileFormat);
            this.SetParamSimple(map, prefix + "ParamSize", this.ParamSize);
            this.SetParamSimple(map, prefix + "Family", this.Family);
            this.SetParamSimple(map, prefix + "IsRecommended", this.IsRecommended);
            this.SetParamSimple(map, prefix + "PushTime", this.PushTime);
        }
    }
}

