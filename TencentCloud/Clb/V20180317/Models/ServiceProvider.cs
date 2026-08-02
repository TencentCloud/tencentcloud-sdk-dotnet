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

namespace TencentCloud.Clb.V20180317.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ServiceProvider : AbstractModel
    {
        
        /// <summary>
        /// <p>BYOK类型</p>
        /// </summary>
        [JsonProperty("AccessType")]
        public string AccessType{ get; set; }

        /// <summary>
        /// <p>单个byok实例下该模型可支持的输入多模态能力列表。</p><p>枚举值：</p><ul><li>text： 支持文本输入</li><li>file： 支持文件输入（当前仅支持pdf）</li><li>image： 支持图像输入</li></ul>
        /// </summary>
        [JsonProperty("InputModalities")]
        public string[] InputModalities{ get; set; }

        /// <summary>
        /// <p>模型协议</p>
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// <p>BYOK的所属厂商</p>
        /// </summary>
        [JsonProperty("Provider")]
        public string Provider{ get; set; }

        /// <summary>
        /// <p>BYOK实例ID</p>
        /// </summary>
        [JsonProperty("ServiceProviderId")]
        public string ServiceProviderId{ get; set; }

        /// <summary>
        /// <p>BYOK名称</p>
        /// </summary>
        [JsonProperty("ServiceProviderName")]
        public string ServiceProviderName{ get; set; }

        /// <summary>
        /// <p>绑定的指定模型组内BYOK实例的调度优先级</p><p>取值范围[0,2]，优先级随数值增大而降低。</p>
        /// </summary>
        [JsonProperty("Order")]
        public ulong? Order{ get; set; }

        /// <summary>
        /// <p>绑定的指定模型组Order相同层级内BYOK实例的调度权重</p>
        /// </summary>
        [JsonProperty("Weight")]
        public ulong? Weight{ get; set; }

        /// <summary>
        /// <p>CMR实例-BYOK实例的模型调度绑定关系状态</p><p>枚举值：</p><ul><li>Configuring： 变配中</li><li>ConfigureFailed： 变配失败</li><li>Deleting： 删除中</li><li>Provisioning： 创建中</li><li>Active： 正常可用</li><li>ProvisionFailed： 创建失败</li><li>DeletionFailed： 删除失败</li></ul>
        /// </summary>
        [JsonProperty("AssociationStatus")]
        public string AssociationStatus{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AccessType", this.AccessType);
            this.SetParamArraySimple(map, prefix + "InputModalities.", this.InputModalities);
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
            this.SetParamSimple(map, prefix + "Provider", this.Provider);
            this.SetParamSimple(map, prefix + "ServiceProviderId", this.ServiceProviderId);
            this.SetParamSimple(map, prefix + "ServiceProviderName", this.ServiceProviderName);
            this.SetParamSimple(map, prefix + "Order", this.Order);
            this.SetParamSimple(map, prefix + "Weight", this.Weight);
            this.SetParamSimple(map, prefix + "AssociationStatus", this.AssociationStatus);
        }
    }
}

