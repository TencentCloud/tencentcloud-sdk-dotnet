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

namespace TencentCloud.Ckafka.V20190819.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateInstancePreRequest : AbstractModel
    {
        
        /// <summary>
        /// 实例名称，是一个不超过 64 个字符的字符串，必须以字母为首字符，剩余部分可以包含字母、数字和横划线(-)
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// 可用区
        /// </summary>
        [JsonProperty("ZoneId")]
        public long? ZoneId{ get; set; }

        /// <summary>
        /// 预付费购买时长，例如 "1m",就是一个月
        /// </summary>
        [JsonProperty("Period")]
        public string Period{ get; set; }

        /// <summary>
        /// 实例规格，1：入门型 ，2： 标准型，3 ：进阶型，4 ：容量型，5： 高阶型1，6：高阶性2, 7： 高阶型3,8： 高阶型4， 9 ：独占型。
        /// </summary>
        [JsonProperty("InstanceType")]
        public long? InstanceType{ get; set; }

        /// <summary>
        /// vpcId，不填默认基础网络
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// 子网id，vpc网络需要传该参数，基础网络可以不传
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// 可选。实例日志的最长保留时间，单位分钟，默认为10080（7天），最大30天，不填默认0，代表不开启日志保留时间回收策略
        /// </summary>
        [JsonProperty("MsgRetentionTime")]
        public long? MsgRetentionTime{ get; set; }

        /// <summary>
        /// 创建实例时可以选择集群Id, 该入参表示集群Id
        /// </summary>
        [JsonProperty("ClusterId")]
        public long? ClusterId{ get; set; }

        /// <summary>
        /// 预付费自动续费标记，0表示默认状态(用户未设置，即初始状态)， 1表示自动续费，2表示明确不自动续费(用户设置)
        /// </summary>
        [JsonProperty("RenewFlag")]
        public long? RenewFlag{ get; set; }

        /// <summary>
        /// 支持指定版本Kafka版本（0.10.2/1.1.1/2.4.2） 。指定专业版参数specificationsType=pro
        /// </summary>
        [JsonProperty("KafkaVersion")]
        public string KafkaVersion{ get; set; }

        /// <summary>
        /// 专业版必须填写 （专业版：profession、标准版：standard） 默认是standard。专业版填profession
        /// </summary>
        [JsonProperty("SpecificationsType")]
        public string SpecificationsType{ get; set; }

        /// <summary>
        /// 磁盘大小,专业版不填写默认最小磁盘,填写后根据磁盘带宽分区数弹性计算
        /// </summary>
        [JsonProperty("DiskSize")]
        public long? DiskSize{ get; set; }

        /// <summary>
        /// 带宽,专业版不填写默认最小带宽,填写后根据磁盘带宽分区数弹性计算
        /// </summary>
        [JsonProperty("BandWidth")]
        public long? BandWidth{ get; set; }

        /// <summary>
        /// 分区大小,专业版不填写默认最小分区数,填写后根据磁盘带宽分区数弹性计算
        /// </summary>
        [JsonProperty("Partition")]
        public long? Partition{ get; set; }

        /// <summary>
        /// 标签
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// 磁盘类型（ssd填写CLOUD_SSD，sata填写CLOUD_BASIC）
        /// </summary>
        [JsonProperty("DiskType")]
        public string DiskType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "Period", this.Period);
            this.SetParamSimple(map, prefix + "InstanceType", this.InstanceType);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "MsgRetentionTime", this.MsgRetentionTime);
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "RenewFlag", this.RenewFlag);
            this.SetParamSimple(map, prefix + "KafkaVersion", this.KafkaVersion);
            this.SetParamSimple(map, prefix + "SpecificationsType", this.SpecificationsType);
            this.SetParamSimple(map, prefix + "DiskSize", this.DiskSize);
            this.SetParamSimple(map, prefix + "BandWidth", this.BandWidth);
            this.SetParamSimple(map, prefix + "Partition", this.Partition);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "DiskType", this.DiskType);
        }
    }
}

