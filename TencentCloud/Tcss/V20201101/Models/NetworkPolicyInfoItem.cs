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

namespace TencentCloud.Tcss.V20201101.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class NetworkPolicyInfoItem : AbstractModel
    {
        
        /// <summary>
        /// 网络策略名
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 网络策略描述
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 发布状态：
        /// 
        /// 开启待确认：PublishedNoConfirm
        /// 
        /// 开启已确认：PublishedConfirmed
        /// 
        /// 关闭中：unPublishing
        /// 
        /// 开启中：Publishing
        /// 
        /// 待开启：unPublishEdit
        /// </summary>
        [JsonProperty("PublishStatus")]
        public string PublishStatus{ get; set; }

        /// <summary>
        /// 策略类型：
        /// 
        /// 自动发现：System
        /// 
        /// 手动添加：Manual
        /// </summary>
        [JsonProperty("PolicySourceType")]
        public string PolicySourceType{ get; set; }

        /// <summary>
        /// 策略空间
        /// </summary>
        [JsonProperty("Namespace")]
        public string Namespace{ get; set; }

        /// <summary>
        /// 策略创建日期
        /// </summary>
        [JsonProperty("PolicyCreateTime")]
        public string PolicyCreateTime{ get; set; }

        /// <summary>
        /// 策略类型
        /// 
        /// kube-router：KubeRouter
        /// 
        /// cilium：Cilium
        /// </summary>
        [JsonProperty("NetworkPolicyPlugin")]
        public string NetworkPolicyPlugin{ get; set; }

        /// <summary>
        /// 策略发布结果
        /// </summary>
        [JsonProperty("PublishResult")]
        public string PublishResult{ get; set; }

        /// <summary>
        /// 入站规则
        /// 
        /// 全部允许：1
        /// 
        /// 全部拒绝 ：2
        /// 
        /// 自定义：3
        /// </summary>
        [JsonProperty("FromPolicyRule")]
        public long? FromPolicyRule{ get; set; }

        /// <summary>
        /// 入站规则
        /// 
        /// 全部允许：1
        /// 
        /// 全部拒绝 ：2
        /// 
        /// 自定义：3
        /// </summary>
        [JsonProperty("ToPolicyRule")]
        public long? ToPolicyRule{ get; set; }

        /// <summary>
        /// 作用对象
        /// </summary>
        [JsonProperty("PodSelector")]
        public string PodSelector{ get; set; }

        /// <summary>
        /// 网络策略Id
        /// </summary>
        [JsonProperty("Id")]
        public ulong? Id{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "PublishStatus", this.PublishStatus);
            this.SetParamSimple(map, prefix + "PolicySourceType", this.PolicySourceType);
            this.SetParamSimple(map, prefix + "Namespace", this.Namespace);
            this.SetParamSimple(map, prefix + "PolicyCreateTime", this.PolicyCreateTime);
            this.SetParamSimple(map, prefix + "NetworkPolicyPlugin", this.NetworkPolicyPlugin);
            this.SetParamSimple(map, prefix + "PublishResult", this.PublishResult);
            this.SetParamSimple(map, prefix + "FromPolicyRule", this.FromPolicyRule);
            this.SetParamSimple(map, prefix + "ToPolicyRule", this.ToPolicyRule);
            this.SetParamSimple(map, prefix + "PodSelector", this.PodSelector);
            this.SetParamSimple(map, prefix + "Id", this.Id);
        }
    }
}

