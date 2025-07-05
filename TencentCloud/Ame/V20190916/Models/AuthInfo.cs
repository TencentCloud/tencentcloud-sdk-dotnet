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

namespace TencentCloud.Ame.V20190916.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AuthInfo : AbstractModel
    {
        
        /// <summary>
        /// 主体名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SubjectName")]
        public string SubjectName{ get; set; }

        /// <summary>
        /// 项目名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ProjectName")]
        public string ProjectName{ get; set; }

        /// <summary>
        /// 应用场景
        /// </summary>
        [JsonProperty("AppScene")]
        public long? AppScene{ get; set; }

        /// <summary>
        /// 应用地域
        /// </summary>
        [JsonProperty("AppRegion")]
        public long? AppRegion{ get; set; }

        /// <summary>
        /// 授权时间
        /// </summary>
        [JsonProperty("AuthPeriod")]
        public long? AuthPeriod{ get; set; }

        /// <summary>
        /// 是否可商业化
        /// </summary>
        [JsonProperty("Commercialization")]
        public long? Commercialization{ get; set; }

        /// <summary>
        /// 是否可跨平台
        /// </summary>
        [JsonProperty("Platform")]
        public long? Platform{ get; set; }

        /// <summary>
        /// 加密后Id
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SubjectName", this.SubjectName);
            this.SetParamSimple(map, prefix + "ProjectName", this.ProjectName);
            this.SetParamSimple(map, prefix + "AppScene", this.AppScene);
            this.SetParamSimple(map, prefix + "AppRegion", this.AppRegion);
            this.SetParamSimple(map, prefix + "AuthPeriod", this.AuthPeriod);
            this.SetParamSimple(map, prefix + "Commercialization", this.Commercialization);
            this.SetParamSimple(map, prefix + "Platform", this.Platform);
            this.SetParamSimple(map, prefix + "Id", this.Id);
        }
    }
}

