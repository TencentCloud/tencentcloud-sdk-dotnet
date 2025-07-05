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

namespace TencentCloud.Mqtt.V20240516.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateInstanceRequest : AbstractModel
    {
        
        /// <summary>
        /// 实例类型，需要和SkuCode保持对应关系，可参考 [获取MQTT产品售卖规格](https://cloud.tencent.com/document/api/1778/116232) 接口获取。
        /// BASIC 基础版
        /// PRO  专业版
        /// PLATINUM 铂金版
        /// </summary>
        [JsonProperty("InstanceType")]
        public string InstanceType{ get; set; }

        /// <summary>
        /// 集群名称不能为空, 3-64个字符，只能包含数字、字母、“-”和“_”。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 商品规格，需要和InstanceType保持对应关系，可参考 [获取MQTT产品售卖规格](https://cloud.tencent.com/document/api/1778/116232) 接口获取。
        /// </summary>
        [JsonProperty("SkuCode")]
        public string SkuCode{ get; set; }

        /// <summary>
        /// 备注信息，最长 128 字符
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// 标签列表
        /// </summary>
        [JsonProperty("TagList")]
        public Tag[] TagList{ get; set; }

        /// <summary>
        /// 实例绑定的VPC信息，需要传当前用户下可用的VPC和SUBNET
        /// </summary>
        [JsonProperty("VpcList")]
        public VpcInfo[] VpcList{ get; set; }

        /// <summary>
        /// 是否开启公网，默认false（关闭）
        /// </summary>
        [JsonProperty("EnablePublic")]
        public bool? EnablePublic{ get; set; }

        /// <summary>
        /// 公网带宽（单位：Mbps），EnablePublic 为True时，该字段必须填写且大于0.
        /// </summary>
        [JsonProperty("Bandwidth")]
        public long? Bandwidth{ get; set; }

        /// <summary>
        /// 公网访问白名单，不传表示拒绝所有IP网络访问。
        /// </summary>
        [JsonProperty("IpRules")]
        public IpRule[] IpRules{ get; set; }

        /// <summary>
        /// 是否自动续费（0: 不自动续费；1: 自动续费），仅购买预付费集群时生效。默认1:自动续费
        /// </summary>
        [JsonProperty("RenewFlag")]
        public long? RenewFlag{ get; set; }

        /// <summary>
        /// 购买时长（单位：月），购买预付费集群时生效，默认1m（月）。可选范围：1~12、24、36、48、60；
        /// </summary>
        [JsonProperty("TimeSpan")]
        public long? TimeSpan{ get; set; }

        /// <summary>
        /// 付费模式（0: 后付费；1: 预付费），默认0（后付费）。
        /// </summary>
        [JsonProperty("PayMode")]
        public long? PayMode{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceType", this.InstanceType);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "SkuCode", this.SkuCode);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamArrayObj(map, prefix + "TagList.", this.TagList);
            this.SetParamArrayObj(map, prefix + "VpcList.", this.VpcList);
            this.SetParamSimple(map, prefix + "EnablePublic", this.EnablePublic);
            this.SetParamSimple(map, prefix + "Bandwidth", this.Bandwidth);
            this.SetParamArrayObj(map, prefix + "IpRules.", this.IpRules);
            this.SetParamSimple(map, prefix + "RenewFlag", this.RenewFlag);
            this.SetParamSimple(map, prefix + "TimeSpan", this.TimeSpan);
            this.SetParamSimple(map, prefix + "PayMode", this.PayMode);
        }
    }
}

