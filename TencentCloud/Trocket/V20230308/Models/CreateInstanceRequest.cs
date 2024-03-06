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

namespace TencentCloud.Trocket.V20230308.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateInstanceRequest : AbstractModel
    {
        
        /// <summary>
        /// 实例类型，
        /// EXPERIMENT 体验版
        /// BASIC 基础版
        /// PRO  专业版
        /// PLATINUM 铂金版
        /// </summary>
        [JsonProperty("InstanceType")]
        public string InstanceType{ get; set; }

        /// <summary>
        /// 实例名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 商品规格，可用规格如下：
        /// experiment_500,
        /// basic_1k,
        /// basic_2k,
        /// basic_4k,
        /// basic_6k,
        /// pro_4k,
        /// pro_6k,
        /// pro_1w,
        /// pro_2w,
        /// pro_3w,
        /// pro_4w,
        /// pro_5w,
        /// platinum_6k,
        /// platinum_1w,
        /// platinum_2w,
        /// platinum_4w,
        /// platinum_10w,
        /// platinum_15w,
        /// platinum_20w,
        /// platinum_40w,
        /// platinum_60w,
        /// platinum_100w
        /// </summary>
        [JsonProperty("SkuCode")]
        public string SkuCode{ get; set; }

        /// <summary>
        /// 备注信息
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// 标签列表
        /// </summary>
        [JsonProperty("TagList")]
        public Tag[] TagList{ get; set; }

        /// <summary>
        /// 实例绑定的VPC信息
        /// </summary>
        [JsonProperty("VpcList")]
        public VpcInfo[] VpcList{ get; set; }

        /// <summary>
        /// 是否开启公网
        /// </summary>
        [JsonProperty("EnablePublic")]
        public bool? EnablePublic{ get; set; }

        /// <summary>
        /// 公网带宽（单位：兆）
        /// </summary>
        [JsonProperty("Bandwidth")]
        public long? Bandwidth{ get; set; }

        /// <summary>
        /// 公网访问白名单
        /// </summary>
        [JsonProperty("IpRules")]
        public IpRule[] IpRules{ get; set; }

        /// <summary>
        /// 消息保留时长（单位：小时）
        /// </summary>
        [JsonProperty("MessageRetention")]
        public long? MessageRetention{ get; set; }

        /// <summary>
        /// 付费模式（0: 后付费；1: 预付费）
        /// </summary>
        [JsonProperty("PayMode")]
        public long? PayMode{ get; set; }

        /// <summary>
        /// 是否自动续费（0: 不自动续费；1: 自动续费）
        /// </summary>
        [JsonProperty("RenewFlag")]
        public long? RenewFlag{ get; set; }

        /// <summary>
        /// 购买时长（单位：月）
        /// </summary>
        [JsonProperty("TimeSpan")]
        public long? TimeSpan{ get; set; }

        /// <summary>
        /// 最大可创建主题数
        /// </summary>
        [JsonProperty("MaxTopicNum")]
        public long? MaxTopicNum{ get; set; }


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
            this.SetParamSimple(map, prefix + "MessageRetention", this.MessageRetention);
            this.SetParamSimple(map, prefix + "PayMode", this.PayMode);
            this.SetParamSimple(map, prefix + "RenewFlag", this.RenewFlag);
            this.SetParamSimple(map, prefix + "TimeSpan", this.TimeSpan);
            this.SetParamSimple(map, prefix + "MaxTopicNum", this.MaxTopicNum);
        }
    }
}

