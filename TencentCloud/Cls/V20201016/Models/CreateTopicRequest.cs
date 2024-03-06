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

namespace TencentCloud.Cls.V20201016.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateTopicRequest : AbstractModel
    {
        
        /// <summary>
        /// 日志集ID
        /// </summary>
        [JsonProperty("LogsetId")]
        public string LogsetId{ get; set; }

        /// <summary>
        /// 日志主题名称
        /// </summary>
        [JsonProperty("TopicName")]
        public string TopicName{ get; set; }

        /// <summary>
        /// 日志主题分区个数。默认创建1个，最大支持创建10个分区。
        /// </summary>
        [JsonProperty("PartitionCount")]
        public long? PartitionCount{ get; set; }

        /// <summary>
        /// 标签描述列表，通过指定该参数可以同时绑定标签到相应的日志主题。最大支持10个标签键值对，同一个资源只能绑定到同一个标签键下。
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// 是否开启自动分裂，默认值为true
        /// </summary>
        [JsonProperty("AutoSplit")]
        public bool? AutoSplit{ get; set; }

        /// <summary>
        /// 开启自动分裂后，每个主题能够允许的最大分区数，默认值为50
        /// </summary>
        [JsonProperty("MaxSplitPartitions")]
        public long? MaxSplitPartitions{ get; set; }

        /// <summary>
        /// 日志主题的存储类型，可选值 hot（标准存储），cold（低频存储）；默认为hot。
        /// </summary>
        [JsonProperty("StorageType")]
        public string StorageType{ get; set; }

        /// <summary>
        /// 生命周期，单位天，标准存储取值范围1\~3600，低频存储取值范围7\~3600天。取值为3640时代表永久保存。
        /// 不传此值，默认获取该日志主题对应日志集的Period值（当获取失败时默认为30天）。
        /// </summary>
        [JsonProperty("Period")]
        public long? Period{ get; set; }

        /// <summary>
        /// 日志主题描述
        /// </summary>
        [JsonProperty("Describes")]
        public string Describes{ get; set; }

        /// <summary>
        /// 0：关闭日志沉降。
        /// 非0：开启日志沉降后标准存储的天数，HotPeriod需要大于等于7，且小于Period。
        /// 仅在StorageType为 hot 时生效。
        /// </summary>
        [JsonProperty("HotPeriod")]
        public ulong? HotPeriod{ get; set; }

        /// <summary>
        /// 免鉴权开关。 false：关闭； true：开启。
        /// 开启后将支持指定操作匿名访问该日志主题。详情请参见[日志主题](https://cloud.tencent.com/document/product/614/41035)。
        /// </summary>
        [JsonProperty("IsWebTracking")]
        public bool? IsWebTracking{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "LogsetId", this.LogsetId);
            this.SetParamSimple(map, prefix + "TopicName", this.TopicName);
            this.SetParamSimple(map, prefix + "PartitionCount", this.PartitionCount);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "AutoSplit", this.AutoSplit);
            this.SetParamSimple(map, prefix + "MaxSplitPartitions", this.MaxSplitPartitions);
            this.SetParamSimple(map, prefix + "StorageType", this.StorageType);
            this.SetParamSimple(map, prefix + "Period", this.Period);
            this.SetParamSimple(map, prefix + "Describes", this.Describes);
            this.SetParamSimple(map, prefix + "HotPeriod", this.HotPeriod);
            this.SetParamSimple(map, prefix + "IsWebTracking", this.IsWebTracking);
        }
    }
}

