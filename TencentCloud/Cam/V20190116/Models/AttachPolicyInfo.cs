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

    public class AttachPolicyInfo : AbstractModel
    {
        
        /// <summary>
        /// 策略id
        /// </summary>
        [JsonProperty("PolicyId")]
        public ulong? PolicyId{ get; set; }

        /// <summary>
        /// 策略名称
        /// </summary>
        [JsonProperty("PolicyName")]
        public string PolicyName{ get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("AddTime")]
        public string AddTime{ get; set; }

        /// <summary>
        /// 创建来源，1 通过控制台创建, 2 通过策略语法创建
        /// </summary>
        [JsonProperty("CreateMode")]
        public ulong? CreateMode{ get; set; }

        /// <summary>
        /// 取值为User和QCS。User代表自定义策略，QCS代表系统策略
        /// </summary>
        [JsonProperty("PolicyType")]
        public string PolicyType{ get; set; }

        /// <summary>
        /// 策略备注
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// 策略关联操作者主账号
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OperateOwnerUin")]
        public string OperateOwnerUin{ get; set; }

        /// <summary>
        /// 策略关联操作者ID，如果UinType为0表示子账号Uin，如果UinType为1表示角色ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OperateUin")]
        public string OperateUin{ get; set; }

        /// <summary>
        /// 取值为0和1。OperateUinType为0表示OperateUin字段是子账号Uin。如果OperateUinType为1表示OperateUin字段是角色ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OperateUinType")]
        public ulong? OperateUinType{ get; set; }

        /// <summary>
        /// 是否已下线，1代表已下线，0代表未下线
        /// </summary>
        [JsonProperty("Deactived")]
        public ulong? Deactived{ get; set; }

        /// <summary>
        /// 已下线的产品列表
        /// </summary>
        [JsonProperty("DeactivedDetail")]
        public string[] DeactivedDetail{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PolicyId", this.PolicyId);
            this.SetParamSimple(map, prefix + "PolicyName", this.PolicyName);
            this.SetParamSimple(map, prefix + "AddTime", this.AddTime);
            this.SetParamSimple(map, prefix + "CreateMode", this.CreateMode);
            this.SetParamSimple(map, prefix + "PolicyType", this.PolicyType);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "OperateOwnerUin", this.OperateOwnerUin);
            this.SetParamSimple(map, prefix + "OperateUin", this.OperateUin);
            this.SetParamSimple(map, prefix + "OperateUinType", this.OperateUinType);
            this.SetParamSimple(map, prefix + "Deactived", this.Deactived);
            this.SetParamArraySimple(map, prefix + "DeactivedDetail.", this.DeactivedDetail);
        }
    }
}

