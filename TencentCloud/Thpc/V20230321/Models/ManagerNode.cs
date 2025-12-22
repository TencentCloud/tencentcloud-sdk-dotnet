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

namespace TencentCloud.Thpc.V20230321.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ManagerNode : AbstractModel
    {
        
        /// <summary>
        /// <p>节点<a href="https://cloud.tencent.com/document/product/213/2180">计费类型</a>。</p>枚举值：<ul><li> PREPAID： 预付费，即包年包月</li><li> POSTPAID_BY_HOUR： 按小时后付费</li></ul>
        /// </summary>
        [JsonProperty("InstanceChargeType")]
        public string InstanceChargeType{ get; set; }

        /// <summary>
        /// <p>预付费模式，即包年包月相关参数设置。通过该参数可以指定包年包月节点的购买时长、是否设置自动续费等属性。若指定节点的付费模式为预付费则该参数必传。</p>
        /// </summary>
        [JsonProperty("InstanceChargePrepaid")]
        public InstanceChargePrepaid InstanceChargePrepaid{ get; set; }

        /// <summary>
        /// <p>节点机型。不同实例机型指定了不同的资源规格。 <br><li>具体取值可通过调用接口<a href="https://cloud.tencent.com/document/api/213/15749">DescribeInstanceTypeConfigs</a>来获得最新的规格表或参见<a href="https://cloud.tencent.com/document/product/213/11518">实例规格</a>描述。</li>   </p>
        /// </summary>
        [JsonProperty("InstanceType")]
        public string InstanceType{ get; set; }

        /// <summary>
        /// <p>节点系统盘配置信息。若不指定该参数，则按照系统默认值进行分配。</p>
        /// </summary>
        [JsonProperty("SystemDisk")]
        public SystemDisk SystemDisk{ get; set; }

        /// <summary>
        /// <p>节点数据盘配置信息。若不指定该参数，则默认不购买数据盘。支持购买的时候指定21块数据盘，其中最多包含1块LOCAL_BASIC数据盘或者LOCAL_SSD数据盘，最多包含20块CLOUD_BASIC数据盘、CLOUD_PREMIUM数据盘或者CLOUD_SSD数据盘。</p>
        /// </summary>
        [JsonProperty("DataDisks")]
        public DataDisk[] DataDisks{ get; set; }

        /// <summary>
        /// <p>公网带宽相关信息设置。若不指定该参数，则默认公网带宽为0Mbps。</p>
        /// </summary>
        [JsonProperty("InternetAccessible")]
        public InternetAccessible InternetAccessible{ get; set; }

        /// <summary>
        /// <p>节点显示名称。<br><li> 不指定节点显示名称则默认显示‘未命名’。 </li><li>购买多个节点，如果指定模式串<code>{R:x}</code>，表示生成数字[<code>[x, x+n-1]</code>，其中<code>n</code>表示购买节点的数量，例如<code>server_{R:3}</code>，购买1个时，节点显示名称为<code>server_3</code>；购买2个时，节点显示名称分别为<code>server_3</code>，<code>server_4</code>。支持指定多个模式串<code>{R:x}</code>。 购买多个节点，如果不指定模式串，则在节点显示名称添加后缀<code>1、2...n</code>，其中<code>n</code>表示购买节点的数量，例如<code>server_</code>，购买2个时，节点显示名称分别为<code>server_1</code>，<code>server_2</code>。</li><li> 最多支持60个字符（包含模式串）。</li></p>
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// <p>实例所属项目ID。该参数可以通过调用 <a href="https://cloud.tencent.com/document/api/651/78725">DescribeProject</a> 的返回值中的 projectId 字段来获取。不填为默认项目。</p>
        /// </summary>
        [JsonProperty("ProjectId")]
        public long? ProjectId{ get; set; }

        /// <summary>
        /// <p>增强服务。通过该参数可以指定是否开启云安全、腾讯云可观测平台等服务。若不指定该参数，则默认开启腾讯云可观测平台、云安全服务、自动化助手服务。</p>
        /// </summary>
        [JsonProperty("EnhancedService")]
        public EnhancedService EnhancedService{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceChargeType", this.InstanceChargeType);
            this.SetParamObj(map, prefix + "InstanceChargePrepaid.", this.InstanceChargePrepaid);
            this.SetParamSimple(map, prefix + "InstanceType", this.InstanceType);
            this.SetParamObj(map, prefix + "SystemDisk.", this.SystemDisk);
            this.SetParamArrayObj(map, prefix + "DataDisks.", this.DataDisks);
            this.SetParamObj(map, prefix + "InternetAccessible.", this.InternetAccessible);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamObj(map, prefix + "EnhancedService.", this.EnhancedService);
        }
    }
}

