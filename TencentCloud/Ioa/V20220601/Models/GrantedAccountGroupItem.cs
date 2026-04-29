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

namespace TencentCloud.Ioa.V20220601.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class GrantedAccountGroupItem : AbstractModel
    {
        
        /// <summary>
        /// 账户组Id
        /// </summary>
        [JsonProperty("AccountGroupId")]
        public ulong? AccountGroupId{ get; set; }

        /// <summary>
        /// 分组名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 所属分组Id
        /// </summary>
        [JsonProperty("IdPathArray")]
        public ulong?[] IdPathArray{ get; set; }

        /// <summary>
        /// 所属分组NamePathArray
        /// </summary>
        [JsonProperty("NamePathArray")]
        public string[] NamePathArray{ get; set; }

        /// <summary>
        /// 目录id
        /// </summary>
        [JsonProperty("AccountCount")]
        public ulong? AccountCount{ get; set; }

        /// <summary>
        /// 过期时间
        /// </summary>
        [JsonProperty("ExpireTime")]
        public ulong? ExpireTime{ get; set; }

        /// <summary>
        /// 关联id
        /// </summary>
        [JsonProperty("RelationId")]
        public ulong? RelationId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AccountGroupId", this.AccountGroupId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamArraySimple(map, prefix + "IdPathArray.", this.IdPathArray);
            this.SetParamArraySimple(map, prefix + "NamePathArray.", this.NamePathArray);
            this.SetParamSimple(map, prefix + "AccountCount", this.AccountCount);
            this.SetParamSimple(map, prefix + "ExpireTime", this.ExpireTime);
            this.SetParamSimple(map, prefix + "RelationId", this.RelationId);
        }
    }
}

