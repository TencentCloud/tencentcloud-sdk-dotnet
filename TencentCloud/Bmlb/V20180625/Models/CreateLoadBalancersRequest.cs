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

namespace TencentCloud.Bmlb.V20180625.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateLoadBalancersRequest : AbstractModel
    {
        
        /// <summary>
        /// 黑石负载均衡实例所属的私有网络ID。
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// 负载均衡的类型，取值为open或internal。open表示公网(有日租)，internal表示内网。
        /// </summary>
        [JsonProperty("LoadBalancerType")]
        public string LoadBalancerType{ get; set; }

        /// <summary>
        /// 在私有网络内购买内网负载均衡实例的时候需要指定子网ID，内网负载均衡实例的VIP将从这个子网中产生。其他情况不用填写该字段。
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// 负载均衡所属项目ID。不填则属于默认项目。
        /// </summary>
        [JsonProperty("ProjectId")]
        public long? ProjectId{ get; set; }

        /// <summary>
        /// 购买黑石负载均衡实例的数量。默认值为1, 最大值为20。
        /// </summary>
        [JsonProperty("GoodsNum")]
        public long? GoodsNum{ get; set; }

        /// <summary>
        /// 黑石负载均衡的计费模式，取值为flow和bandwidth，其中flow模式表示流量模式，bandwidth表示带宽模式。默认值为flow。
        /// </summary>
        [JsonProperty("PayMode")]
        public string PayMode{ get; set; }

        /// <summary>
        /// 负载均衡对应的TGW集群类别，取值为tunnel、fullnat或dnat。tunnel表示隧道集群，fullnat表示FULLNAT集群，dnat表示DNAT集群。默认值为fullnat。如需获取client IP，可以选择 tunnel 模式，fullnat 模式（tcp 通过toa 获取），dnat 模式。
        /// </summary>
        [JsonProperty("TgwSetType")]
        public string TgwSetType{ get; set; }

        /// <summary>
        /// 负载均衡的独占类别，取值为0表示非独占，1表示四层独占，2表示七层独占，3表示四层和七层独占，4表示共享容灾。
        /// </summary>
        [JsonProperty("Exclusive")]
        public long? Exclusive{ get; set; }

        /// <summary>
        /// 指定的VIP，如果指定，则数量必须与goodsNum一致。如果不指定，则由后台分配随机VIP。
        /// </summary>
        [JsonProperty("SpecifiedVips")]
        public string[] SpecifiedVips{ get; set; }

        /// <summary>
        /// （未全地域开放）保障型负载均衡设定参数，如果类别选择保障型则需传入此参数。
        /// </summary>
        [JsonProperty("BzConf")]
        public CreateLoadBalancerBzConf BzConf{ get; set; }

        /// <summary>
        /// IP协议类型。可取的值为“ipv4”或“ipv6”。
        /// </summary>
        [JsonProperty("IpProtocolType")]
        public string IpProtocolType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "LoadBalancerType", this.LoadBalancerType);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "GoodsNum", this.GoodsNum);
            this.SetParamSimple(map, prefix + "PayMode", this.PayMode);
            this.SetParamSimple(map, prefix + "TgwSetType", this.TgwSetType);
            this.SetParamSimple(map, prefix + "Exclusive", this.Exclusive);
            this.SetParamArraySimple(map, prefix + "SpecifiedVips.", this.SpecifiedVips);
            this.SetParamObj(map, prefix + "BzConf.", this.BzConf);
            this.SetParamSimple(map, prefix + "IpProtocolType", this.IpProtocolType);
        }
    }
}

