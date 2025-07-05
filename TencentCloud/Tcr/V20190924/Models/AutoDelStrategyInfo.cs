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

    public class AutoDelStrategyInfo : AbstractModel
    {
        
        /// <summary>
        /// 用户名
        /// </summary>
        [JsonProperty("Username")]
        public string Username{ get; set; }

        /// <summary>
        /// 仓库名
        /// </summary>
        [JsonProperty("RepoName")]
        public string RepoName{ get; set; }

        /// <summary>
        /// 类型
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 策略值
        /// </summary>
        [JsonProperty("Value")]
        public long? Value{ get; set; }

        /// <summary>
        /// Valid
        /// </summary>
        [JsonProperty("Valid")]
        public long? Valid{ get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("CreationTime")]
        public string CreationTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Username", this.Username);
            this.SetParamSimple(map, prefix + "RepoName", this.RepoName);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Value", this.Value);
            this.SetParamSimple(map, prefix + "Valid", this.Valid);
            this.SetParamSimple(map, prefix + "CreationTime", this.CreationTime);
        }
    }
}

