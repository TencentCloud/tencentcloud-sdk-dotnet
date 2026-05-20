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

namespace TencentCloud.Wedata.V20210820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class GetCosTokenRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>项目id</p>
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// <p>请求域名</p>
        /// </summary>
        [JsonProperty("OriginDomain")]
        public string OriginDomain{ get; set; }

        /// <summary>
        /// <p>是否需要跨域</p>
        /// </summary>
        [JsonProperty("CrossFlag")]
        public bool? CrossFlag{ get; set; }

        /// <summary>
        /// <p>桶名</p>
        /// </summary>
        [JsonProperty("BucketName")]
        public string BucketName{ get; set; }

        /// <summary>
        /// <p>远程地址</p>
        /// </summary>
        [JsonProperty("RemotePath")]
        public string RemotePath{ get; set; }

        /// <summary>
        /// <p>地域</p>
        /// </summary>
        [JsonProperty("RemoteRegion")]
        public string RemoteRegion{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "OriginDomain", this.OriginDomain);
            this.SetParamSimple(map, prefix + "CrossFlag", this.CrossFlag);
            this.SetParamSimple(map, prefix + "BucketName", this.BucketName);
            this.SetParamSimple(map, prefix + "RemotePath", this.RemotePath);
            this.SetParamSimple(map, prefix + "RemoteRegion", this.RemoteRegion);
        }
    }
}

