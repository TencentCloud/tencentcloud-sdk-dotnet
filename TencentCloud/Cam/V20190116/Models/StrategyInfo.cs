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

namespace TencentCloud.Cam.V20190116.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class StrategyInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>策略ID。</p>
        /// </summary>
        [JsonProperty("PolicyId")]
        public ulong? PolicyId{ get; set; }

        /// <summary>
        /// <p>策略名称。</p>
        /// </summary>
        [JsonProperty("PolicyName")]
        public string PolicyName{ get; set; }

        /// <summary>
        /// <p>策略创建时间。</p>
        /// </summary>
        [JsonProperty("AddTime")]
        public string AddTime{ get; set; }

        /// <summary>
        /// <p>策略类型。1 表示自定义策略，2 表示预设策略。</p>
        /// </summary>
        [JsonProperty("Type")]
        public ulong? Type{ get; set; }

        /// <summary>
        /// <p>策略描述。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// <p>创建来源，1 通过控制台创建, 2 通过策略语法创建。</p>
        /// </summary>
        [JsonProperty("CreateMode")]
        public ulong? CreateMode{ get; set; }

        /// <summary>
        /// <p>关联的用户数</p>
        /// </summary>
        [JsonProperty("Attachments")]
        public ulong? Attachments{ get; set; }

        /// <summary>
        /// <p>策略关联的产品</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ServiceType")]
        public string ServiceType{ get; set; }

        /// <summary>
        /// <p>当需要查询标记实体是否已经关联策略时不为null。0表示未关联策略，1表示已关联策略</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IsAttached")]
        public ulong? IsAttached{ get; set; }

        /// <summary>
        /// <p>是否已下线</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Deactived")]
        public ulong? Deactived{ get; set; }

        /// <summary>
        /// <p>已下线产品列表</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DeactivedDetail")]
        public string[] DeactivedDetail{ get; set; }

        /// <summary>
        /// <p>是否是服务相关角色策略</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IsServiceLinkedPolicy")]
        public ulong? IsServiceLinkedPolicy{ get; set; }

        /// <summary>
        /// <p>关联策略实体数</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AttachEntityCount")]
        public long? AttachEntityCount{ get; set; }

        /// <summary>
        /// <p>关联权限边界实体数</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AttachEntityBoundaryCount")]
        public long? AttachEntityBoundaryCount{ get; set; }

        /// <summary>
        /// <p>最后编辑时间</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// <p>标签列表</p>
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// <p>权限级别</p><p>枚举值：</p><ul><li>Global： 全局权限</li><li>Finance： 财务权限</li><li>CloudProduct： 云产品权限</li></ul>
        /// </summary>
        [JsonProperty("PermissionLevel")]
        public string PermissionLevel{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PolicyId", this.PolicyId);
            this.SetParamSimple(map, prefix + "PolicyName", this.PolicyName);
            this.SetParamSimple(map, prefix + "AddTime", this.AddTime);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "CreateMode", this.CreateMode);
            this.SetParamSimple(map, prefix + "Attachments", this.Attachments);
            this.SetParamSimple(map, prefix + "ServiceType", this.ServiceType);
            this.SetParamSimple(map, prefix + "IsAttached", this.IsAttached);
            this.SetParamSimple(map, prefix + "Deactived", this.Deactived);
            this.SetParamArraySimple(map, prefix + "DeactivedDetail.", this.DeactivedDetail);
            this.SetParamSimple(map, prefix + "IsServiceLinkedPolicy", this.IsServiceLinkedPolicy);
            this.SetParamSimple(map, prefix + "AttachEntityCount", this.AttachEntityCount);
            this.SetParamSimple(map, prefix + "AttachEntityBoundaryCount", this.AttachEntityBoundaryCount);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "PermissionLevel", this.PermissionLevel);
        }
    }
}

