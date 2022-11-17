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

    public class DidServiceInfo : AbstractModel
    {
        
        /// <summary>
        /// DID服务索引
        /// </summary>
        [JsonProperty("Id")]
        public ulong? Id{ get; set; }

        /// <summary>
        /// 应用ID
        /// </summary>
        [JsonProperty("Appid")]
        public ulong? Appid{ get; set; }

        /// <summary>
        /// 账号唯一标识
        /// </summary>
        [JsonProperty("Uin")]
        public string Uin{ get; set; }

        /// <summary>
        /// 联盟id
        /// </summary>
        [JsonProperty("ConsortiumId")]
        public long? ConsortiumId{ get; set; }

        /// <summary>
        /// 联盟名称
        /// </summary>
        [JsonProperty("ConsortiumName")]
        public string ConsortiumName{ get; set; }

        /// <summary>
        /// 网络ID
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// 群组ID
        /// </summary>
        [JsonProperty("GroupId")]
        public long? GroupId{ get; set; }

        /// <summary>
        /// 链ID
        /// </summary>
        [JsonProperty("ChainId")]
        public string ChainId{ get; set; }

        /// <summary>
        /// 1为盟主，0为非盟主
        /// </summary>
        [JsonProperty("RoleType")]
        public ulong? RoleType{ get; set; }

        /// <summary>
        /// 机构DID
        /// </summary>
        [JsonProperty("AgencyDid")]
        public string AgencyDid{ get; set; }

        /// <summary>
        /// 机构名称
        /// </summary>
        [JsonProperty("CreateOrg")]
        public string CreateOrg{ get; set; }

        /// <summary>
        /// 端点
        /// </summary>
        [JsonProperty("Endpoint")]
        public string Endpoint{ get; set; }

        /// <summary>
        /// 生成时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// 群组名称
        /// </summary>
        [JsonProperty("GroupName")]
        public string GroupName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "Appid", this.Appid);
            this.SetParamSimple(map, prefix + "Uin", this.Uin);
            this.SetParamSimple(map, prefix + "ConsortiumId", this.ConsortiumId);
            this.SetParamSimple(map, prefix + "ConsortiumName", this.ConsortiumName);
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "GroupId", this.GroupId);
            this.SetParamSimple(map, prefix + "ChainId", this.ChainId);
            this.SetParamSimple(map, prefix + "RoleType", this.RoleType);
            this.SetParamSimple(map, prefix + "AgencyDid", this.AgencyDid);
            this.SetParamSimple(map, prefix + "CreateOrg", this.CreateOrg);
            this.SetParamSimple(map, prefix + "Endpoint", this.Endpoint);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "GroupName", this.GroupName);
        }
    }
}

