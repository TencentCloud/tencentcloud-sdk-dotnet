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

namespace TencentCloud.Databuddy.V20260715.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class GitRepoConfig : AbstractModel
    {
        
        /// <summary>
        /// <p>检出规则</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SparseCheckout")]
        public SparseCheckoutConfig SparseCheckout{ get; set; }

        /// <summary>
        /// <p>Git 仓库地址</p>
        /// </summary>
        [JsonProperty("RepoUrl")]
        public string RepoUrl{ get; set; }

        /// <summary>
        /// <p>分支名</p>
        /// </summary>
        [JsonProperty("Branch")]
        public string Branch{ get; set; }

        /// <summary>
        /// <p>关联的 gitAuth 配置名称</p>
        /// </summary>
        [JsonProperty("AuthConfigName")]
        public string AuthConfigName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "SparseCheckout.", this.SparseCheckout);
            this.SetParamSimple(map, prefix + "RepoUrl", this.RepoUrl);
            this.SetParamSimple(map, prefix + "Branch", this.Branch);
            this.SetParamSimple(map, prefix + "AuthConfigName", this.AuthConfigName);
        }
    }
}

