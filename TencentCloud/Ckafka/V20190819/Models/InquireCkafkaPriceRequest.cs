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

namespace TencentCloud.Ckafka.V20190819.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class InquireCkafkaPriceRequest : AbstractModel
    {
        
        /// <summary>
        /// 国内站标准版填写standards2, 国际站标准版填写standard,专业版填写profession,高级版填写premium
        /// </summary>
        [JsonProperty("InstanceType")]
        public string InstanceType{ get; set; }

        /// <summary>
        /// 购买/续费付费类型(购买时不填的话, 默认获取购买包年包月一个月的费用)
        /// </summary>
        [JsonProperty("InstanceChargeParam")]
        public InstanceChargeParam InstanceChargeParam{ get; set; }

        /// <summary>
        /// 购买/续费时购买的实例数量(不填时, 默认为1个)
        /// </summary>
        [JsonProperty("InstanceNum")]
        public long? InstanceNum{ get; set; }

        /// <summary>
        /// 实例内网带宽大小, 单位MB/s (购买时必填，专业版/高级版询价时带宽信息必填)
        /// </summary>
        [JsonProperty("Bandwidth")]
        public long? Bandwidth{ get; set; }

        /// <summary>
        /// 实例的硬盘购买类型以及大小 (购买时必填，专业版/高级版询价时磁盘信息必填)
        /// </summary>
        [JsonProperty("InquiryDiskParam")]
        public InquiryDiskParam InquiryDiskParam{ get; set; }

        /// <summary>
        /// 实例消息保留时间大小, 单位小时 (购买时必填)
        /// </summary>
        [JsonProperty("MessageRetention")]
        public long? MessageRetention{ get; set; }

        /// <summary>
        /// 购买实例topic数, 单位个 (购买时必填)
        /// </summary>
        [JsonProperty("Topic")]
        public long? Topic{ get; set; }

        /// <summary>
        /// 购买实例分区数, 单位个 (购买时必填，专业版/高级版询价时带宽信息必填)
        /// </summary>
        [JsonProperty("Partition")]
        public long? Partition{ get; set; }

        /// <summary>
        /// 购买地域, 可通过查看DescribeCkafkaZone这个接口获取ZoneId
        /// </summary>
        [JsonProperty("ZoneIds")]
        public long?[] ZoneIds{ get; set; }

        /// <summary>
        /// 标记操作, 新购填写purchase, 续费填写renew, (不填时, 默认为purchase)
        /// </summary>
        [JsonProperty("CategoryAction")]
        public string CategoryAction{ get; set; }

        /// <summary>
        /// 国内站购买的版本, sv_ckafka_instance_s2_1(入门型), sv_ckafka_instance_s2_2(标准版), sv_ckafka_instance_s2_3(进阶型), 如果instanceType为standards2, 但该参数为空, 则默认值为sv_ckafka_instance_s2_1
        /// </summary>
        [JsonProperty("BillType")]
        public string BillType{ get; set; }

        /// <summary>
        /// 公网带宽计费模式, 目前只有专业版支持公网带宽 (购买公网带宽时必填)
        /// </summary>
        [JsonProperty("PublicNetworkParam")]
        public InquiryPublicNetworkParam PublicNetworkParam{ get; set; }

        /// <summary>
        /// 续费时的实例id, 续费时填写
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceType", this.InstanceType);
            this.SetParamObj(map, prefix + "InstanceChargeParam.", this.InstanceChargeParam);
            this.SetParamSimple(map, prefix + "InstanceNum", this.InstanceNum);
            this.SetParamSimple(map, prefix + "Bandwidth", this.Bandwidth);
            this.SetParamObj(map, prefix + "InquiryDiskParam.", this.InquiryDiskParam);
            this.SetParamSimple(map, prefix + "MessageRetention", this.MessageRetention);
            this.SetParamSimple(map, prefix + "Topic", this.Topic);
            this.SetParamSimple(map, prefix + "Partition", this.Partition);
            this.SetParamArraySimple(map, prefix + "ZoneIds.", this.ZoneIds);
            this.SetParamSimple(map, prefix + "CategoryAction", this.CategoryAction);
            this.SetParamSimple(map, prefix + "BillType", this.BillType);
            this.SetParamObj(map, prefix + "PublicNetworkParam.", this.PublicNetworkParam);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
        }
    }
}

