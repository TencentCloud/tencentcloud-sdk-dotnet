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

namespace TencentCloud.Tdid.V20210519.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Contract : AbstractModel
    {
        
        /// <summary>
        /// 应用名
        /// </summary>
        [JsonProperty("ApplyName")]
        public string ApplyName{ get; set; }

        /// <summary>
        /// 合约状态 true:已启用 false:未启用
        /// </summary>
        [JsonProperty("Enable")]
        public bool? Enable{ get; set; }

        /// <summary>
        /// 合约CNS地址
        /// </summary>
        [JsonProperty("Hash")]
        public string Hash{ get; set; }

        /// <summary>
        /// 合约CNS地址脱敏
        /// </summary>
        [JsonProperty("HashShow")]
        public string HashShow{ get; set; }

        /// <summary>
        /// 部署机构DID
        /// </summary>
        [JsonProperty("WeId")]
        public string WeId{ get; set; }

        /// <summary>
        /// 部署机构名称
        /// </summary>
        [JsonProperty("DeployName")]
        public string DeployName{ get; set; }

        /// <summary>
        /// 部署群组
        /// </summary>
        [JsonProperty("GroupId")]
        public string GroupId{ get; set; }

        /// <summary>
        /// 部署时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ApplyName", this.ApplyName);
            this.SetParamSimple(map, prefix + "Enable", this.Enable);
            this.SetParamSimple(map, prefix + "Hash", this.Hash);
            this.SetParamSimple(map, prefix + "HashShow", this.HashShow);
            this.SetParamSimple(map, prefix + "WeId", this.WeId);
            this.SetParamSimple(map, prefix + "DeployName", this.DeployName);
            this.SetParamSimple(map, prefix + "GroupId", this.GroupId);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
        }
    }
}

