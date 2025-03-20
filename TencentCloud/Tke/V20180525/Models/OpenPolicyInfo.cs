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

namespace TencentCloud.Tke.V20180525.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class OpenPolicyInfo : AbstractModel
    {
        
        /// <summary>
        /// 策略分类：cluster集群策略、node节点策略、namespace命名空间策略、configuration配置相关策略、compute计算资源策略、storage存储资源策略、network网络资源策略
        /// </summary>
        [JsonProperty("PolicyCategory")]
        public string PolicyCategory{ get; set; }

        /// <summary>
        /// 策略中文名称
        /// </summary>
        [JsonProperty("PolicyName")]
        public string PolicyName{ get; set; }

        /// <summary>
        /// 策略描述
        /// </summary>
        [JsonProperty("PolicyDesc")]
        public string PolicyDesc{ get; set; }

        /// <summary>
        /// 策略运行模式：dryrun空跑不生效，deny拦截生效
        /// </summary>
        [JsonProperty("EnforcementAction")]
        public string EnforcementAction{ get; set; }

        /// <summary>
        /// 关联的事件数量(最近7d)
        /// </summary>
        [JsonProperty("EventNums")]
        public ulong? EventNums{ get; set; }

        /// <summary>
        /// 策略英文名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 策略模板类型
        /// </summary>
        [JsonProperty("Kind")]
        public string Kind{ get; set; }

        /// <summary>
        /// 策略开关状态：open打开，close关闭
        /// </summary>
        [JsonProperty("EnabledStatus")]
        public string EnabledStatus{ get; set; }

        /// <summary>
        /// 策略的实例的yaml示例base64编码
        /// </summary>
        [JsonProperty("ConstraintYamlExample")]
        public string ConstraintYamlExample{ get; set; }

        /// <summary>
        /// 策略关联的实例列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OpenConstraintInfoList")]
        public OpenConstraintInfo[] OpenConstraintInfoList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PolicyCategory", this.PolicyCategory);
            this.SetParamSimple(map, prefix + "PolicyName", this.PolicyName);
            this.SetParamSimple(map, prefix + "PolicyDesc", this.PolicyDesc);
            this.SetParamSimple(map, prefix + "EnforcementAction", this.EnforcementAction);
            this.SetParamSimple(map, prefix + "EventNums", this.EventNums);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Kind", this.Kind);
            this.SetParamSimple(map, prefix + "EnabledStatus", this.EnabledStatus);
            this.SetParamSimple(map, prefix + "ConstraintYamlExample", this.ConstraintYamlExample);
            this.SetParamArrayObj(map, prefix + "OpenConstraintInfoList.", this.OpenConstraintInfoList);
        }
    }
}

