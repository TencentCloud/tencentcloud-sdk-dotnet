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

namespace TencentCloud.Cls.V20201016.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TopicInfo : AbstractModel
    {
        
        /// <summary>
        /// 日志集ID
        /// </summary>
        [JsonProperty("LogsetId")]
        public string LogsetId{ get; set; }

        /// <summary>
        /// 主题ID
        /// </summary>
        [JsonProperty("TopicId")]
        public string TopicId{ get; set; }

        /// <summary>
        /// 主题名称
        /// </summary>
        [JsonProperty("TopicName")]
        public string TopicName{ get; set; }

        /// <summary>
        /// 主题分区个数
        /// </summary>
        [JsonProperty("PartitionCount")]
        public long? PartitionCount{ get; set; }

        /// <summary>
        /// 主题是否开启索引（主题类型需为日志主题）
        /// </summary>
        [JsonProperty("Index")]
        public bool? Index{ get; set; }

        /// <summary>
        /// 云产品标识，主题由其它云产品创建时，该字段会显示云产品名称，例如CDN、TKE
        /// </summary>
        [JsonProperty("AssumerName")]
        public string AssumerName{ get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 主题是否开启采集，true：开启采集；false：关闭采集。
        /// 创建日志主题时默认开启，可通过SDK调用ModifyTopic修改此字段。
        /// 控制台目前不支持修改此参数。
        /// </summary>
        [JsonProperty("Status")]
        public bool? Status{ get; set; }

        /// <summary>
        /// 主题绑定的标签信息
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// 该主题是否开启自动分裂
        /// </summary>
        [JsonProperty("AutoSplit")]
        public bool? AutoSplit{ get; set; }

        /// <summary>
        /// 若开启自动分裂的话，该主题能够允许的最大分区数
        /// </summary>
        [JsonProperty("MaxSplitPartitions")]
        public long? MaxSplitPartitions{ get; set; }

        /// <summary>
        /// 主题的存储类型
        /// 
        /// - hot: 标准存储
        /// - cold: 低频存储
        /// </summary>
        [JsonProperty("StorageType")]
        public string StorageType{ get; set; }

        /// <summary>
        /// 生命周期，单位天，可取值范围1~3600。取值为3640时代表永久保存
        /// </summary>
        [JsonProperty("Period")]
        public long? Period{ get; set; }

        /// <summary>
        /// 云产品二级标识，日志主题由其它云产品创建时，该字段会显示云产品名称及其日志类型的二级分类，例如TKE-Audit、TKE-Event。部分云产品仅有云产品标识(AssumerName)，无该字段。
        /// </summary>
        [JsonProperty("SubAssumerName")]
        public string SubAssumerName{ get; set; }

        /// <summary>
        /// 主题描述
        /// </summary>
        [JsonProperty("Describes")]
        public string Describes{ get; set; }

        /// <summary>
        /// 开启日志沉降，标准存储的生命周期， hotPeriod < Period。
        /// 标准存储为 hotPeriod, 低频存储则为 Period-hotPeriod。（主题类型需为日志主题）
        /// HotPeriod=0为没有开启日志沉降。
        /// </summary>
        [JsonProperty("HotPeriod")]
        public ulong? HotPeriod{ get; set; }

        /// <summary>
        /// 主题类型。
        /// - 0: 日志主题 
        /// - 1: 指标主题
        /// </summary>
        [JsonProperty("BizType")]
        public ulong? BizType{ get; set; }

        /// <summary>
        /// 免鉴权开关。 false：关闭； true：开启。
        /// 开启后将支持指定操作匿名访问该日志主题。详情请参见[日志主题](https://cloud.tencent.com/document/product/614/41035)。
        /// </summary>
        [JsonProperty("IsWebTracking")]
        public bool? IsWebTracking{ get; set; }

        /// <summary>
        /// 日志主题扩展信息
        /// </summary>
        [JsonProperty("Extends")]
        public TopicExtendInfo Extends{ get; set; }

        /// <summary>
        /// 异步迁移任务ID
        /// </summary>
        [JsonProperty("TopicAsyncTaskID")]
        public string TopicAsyncTaskID{ get; set; }

        /// <summary>
        /// 异步迁移状态
        /// </summary>
        [JsonProperty("MigrationStatus")]
        public ulong? MigrationStatus{ get; set; }

        /// <summary>
        /// 异步迁移完成后，预计生效日期
        /// </summary>
        [JsonProperty("EffectiveDate")]
        public string EffectiveDate{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "LogsetId", this.LogsetId);
            this.SetParamSimple(map, prefix + "TopicId", this.TopicId);
            this.SetParamSimple(map, prefix + "TopicName", this.TopicName);
            this.SetParamSimple(map, prefix + "PartitionCount", this.PartitionCount);
            this.SetParamSimple(map, prefix + "Index", this.Index);
            this.SetParamSimple(map, prefix + "AssumerName", this.AssumerName);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "AutoSplit", this.AutoSplit);
            this.SetParamSimple(map, prefix + "MaxSplitPartitions", this.MaxSplitPartitions);
            this.SetParamSimple(map, prefix + "StorageType", this.StorageType);
            this.SetParamSimple(map, prefix + "Period", this.Period);
            this.SetParamSimple(map, prefix + "SubAssumerName", this.SubAssumerName);
            this.SetParamSimple(map, prefix + "Describes", this.Describes);
            this.SetParamSimple(map, prefix + "HotPeriod", this.HotPeriod);
            this.SetParamSimple(map, prefix + "BizType", this.BizType);
            this.SetParamSimple(map, prefix + "IsWebTracking", this.IsWebTracking);
            this.SetParamObj(map, prefix + "Extends.", this.Extends);
            this.SetParamSimple(map, prefix + "TopicAsyncTaskID", this.TopicAsyncTaskID);
            this.SetParamSimple(map, prefix + "MigrationStatus", this.MigrationStatus);
            this.SetParamSimple(map, prefix + "EffectiveDate", this.EffectiveDate);
        }
    }
}

