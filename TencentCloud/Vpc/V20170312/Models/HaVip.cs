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

namespace TencentCloud.Vpc.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class HaVip : AbstractModel
    {
        
        /// <summary>
        /// <p><code>HAVIP</code>的<code>ID</code>，是<code>HAVIP</code>的唯一标识。</p>
        /// </summary>
        [JsonProperty("HaVipId")]
        public string HaVipId{ get; set; }

        /// <summary>
        /// <p><code>HAVIP</code>名称。</p>
        /// </summary>
        [JsonProperty("HaVipName")]
        public string HaVipName{ get; set; }

        /// <summary>
        /// <p>虚拟IP地址。</p>
        /// </summary>
        [JsonProperty("Vip")]
        public string Vip{ get; set; }

        /// <summary>
        /// <p><code>HAVIP</code>所在私有网络<code>ID</code>。</p>
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// <p><code>HAVIP</code>所在子网<code>ID</code>。</p>
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// <p><code>HAVIP</code>关联弹性网卡<code>ID</code>。</p>
        /// </summary>
        [JsonProperty("NetworkInterfaceId")]
        public string NetworkInterfaceId{ get; set; }

        /// <summary>
        /// <p>被绑定的实例<code>ID</code>。</p>
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// <p>绑定<code>EIP</code>。</p>
        /// </summary>
        [JsonProperty("AddressIp")]
        public string AddressIp{ get; set; }

        /// <summary>
        /// <p>状态：</p><li><code>AVAILABLE</code>：运行中</li><li><code>UNBIND</code>：未绑定</li>
        /// </summary>
        [JsonProperty("State")]
        public string State{ get; set; }

        /// <summary>
        /// <p>创建时间。</p>
        /// </summary>
        [JsonProperty("CreatedTime")]
        public string CreatedTime{ get; set; }

        /// <summary>
        /// <p>使用havip的业务标识。</p>
        /// </summary>
        [JsonProperty("Business")]
        public string Business{ get; set; }

        /// <summary>
        /// <p><code>HAVIP</code>的飘移范围。</p>
        /// </summary>
        [JsonProperty("HaVipAssociationSet")]
        public HaVipAssociation[] HaVipAssociationSet{ get; set; }

        /// <summary>
        /// <p>是否开启<code>HAVIP</code>的漂移范围校验。</p>
        /// </summary>
        [JsonProperty("CheckAssociate")]
        public bool? CheckAssociate{ get; set; }

        /// <summary>
        /// <p>CDC实例ID。</p>
        /// </summary>
        [JsonProperty("CdcId")]
        public string CdcId{ get; set; }

        /// <summary>
        /// <p>HAVIP 刷新时间。该参数只作为出参数。以下场景会触发FlushedTime 被刷新：1）子机发出免费 ARP 触发 HAVIP 漂移；2）手动HAVIP解绑网卡; 没有更新时默认值：0000-00-00 00:00:00</p>
        /// </summary>
        [JsonProperty("FlushedTime")]
        public string FlushedTime{ get; set; }

        /// <summary>
        /// <p>标签键值对。</p>
        /// </summary>
        [JsonProperty("TagSet")]
        public Tag[] TagSet{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "HaVipId", this.HaVipId);
            this.SetParamSimple(map, prefix + "HaVipName", this.HaVipName);
            this.SetParamSimple(map, prefix + "Vip", this.Vip);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "NetworkInterfaceId", this.NetworkInterfaceId);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "AddressIp", this.AddressIp);
            this.SetParamSimple(map, prefix + "State", this.State);
            this.SetParamSimple(map, prefix + "CreatedTime", this.CreatedTime);
            this.SetParamSimple(map, prefix + "Business", this.Business);
            this.SetParamArrayObj(map, prefix + "HaVipAssociationSet.", this.HaVipAssociationSet);
            this.SetParamSimple(map, prefix + "CheckAssociate", this.CheckAssociate);
            this.SetParamSimple(map, prefix + "CdcId", this.CdcId);
            this.SetParamSimple(map, prefix + "FlushedTime", this.FlushedTime);
            this.SetParamArrayObj(map, prefix + "TagSet.", this.TagSet);
        }
    }
}

