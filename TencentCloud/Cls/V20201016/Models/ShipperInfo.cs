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

    public class ShipperInfo : AbstractModel
    {
        
        /// <summary>
        /// 投递规则ID
        /// </summary>
        [JsonProperty("ShipperId")]
        public string ShipperId{ get; set; }

        /// <summary>
        /// 日志主题ID
        /// </summary>
        [JsonProperty("TopicId")]
        public string TopicId{ get; set; }

        /// <summary>
        /// 投递的bucket地址
        /// </summary>
        [JsonProperty("Bucket")]
        public string Bucket{ get; set; }

        /// <summary>
        /// 投递的前缀目录
        /// </summary>
        [JsonProperty("Prefix")]
        public string Prefix{ get; set; }

        /// <summary>
        /// 投递规则的名字
        /// </summary>
        [JsonProperty("ShipperName")]
        public string ShipperName{ get; set; }

        /// <summary>
        /// 投递的时间间隔，单位 秒
        /// </summary>
        [JsonProperty("Interval")]
        public ulong? Interval{ get; set; }

        /// <summary>
        /// 投递的文件的最大值，单位 MB
        /// </summary>
        [JsonProperty("MaxSize")]
        public ulong? MaxSize{ get; set; }

        /// <summary>
        /// 是否生效
        /// </summary>
        [JsonProperty("Status")]
        public bool? Status{ get; set; }

        /// <summary>
        /// 投递日志的过滤规则
        /// </summary>
        [JsonProperty("FilterRules")]
        public FilterRuleInfo[] FilterRules{ get; set; }

        /// <summary>
        /// 投递日志的分区规则，支持strftime的时间格式表示
        /// </summary>
        [JsonProperty("Partition")]
        public string Partition{ get; set; }

        /// <summary>
        /// 投递日志的压缩配置
        /// </summary>
        [JsonProperty("Compress")]
        public CompressInfo Compress{ get; set; }

        /// <summary>
        /// 投递日志的内容格式配置
        /// </summary>
        [JsonProperty("Content")]
        public ContentInfo Content{ get; set; }

        /// <summary>
        /// 投递日志的创建时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 投递文件命名配置，0：随机数命名，1：投递时间命名，默认0（随机数命名）
        /// </summary>
        [JsonProperty("FilenameMode")]
        public ulong? FilenameMode{ get; set; }

        /// <summary>
        /// 投递数据范围的开始时间点
        /// </summary>
        [JsonProperty("StartTime")]
        public long? StartTime{ get; set; }

        /// <summary>
        /// 投递数据范围的结束时间点
        /// </summary>
        [JsonProperty("EndTime")]
        public long? EndTime{ get; set; }

        /// <summary>
        /// 历史数据投递的进度（仅当用户选择的数据内中历史数据时才有效）
        /// </summary>
        [JsonProperty("Progress")]
        public float? Progress{ get; set; }

        /// <summary>
        /// 历史数据全部投递完成剩余的时间（仅当用户选择的数据中有历史数据时才有效）
        /// </summary>
        [JsonProperty("RemainTime")]
        public long? RemainTime{ get; set; }

        /// <summary>
        /// 历史任务状态：
        /// 0：实时任务
        /// 1：任务准备中
        /// 2：任务运行中
        /// 3：任务运行异常
        /// 4：任务运行结束
        /// </summary>
        [JsonProperty("HistoryStatus")]
        public long? HistoryStatus{ get; set; }

        /// <summary>
        /// cos桶类型
        /// </summary>
        [JsonProperty("StorageType")]
        public string StorageType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ShipperId", this.ShipperId);
            this.SetParamSimple(map, prefix + "TopicId", this.TopicId);
            this.SetParamSimple(map, prefix + "Bucket", this.Bucket);
            this.SetParamSimple(map, prefix + "Prefix", this.Prefix);
            this.SetParamSimple(map, prefix + "ShipperName", this.ShipperName);
            this.SetParamSimple(map, prefix + "Interval", this.Interval);
            this.SetParamSimple(map, prefix + "MaxSize", this.MaxSize);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamArrayObj(map, prefix + "FilterRules.", this.FilterRules);
            this.SetParamSimple(map, prefix + "Partition", this.Partition);
            this.SetParamObj(map, prefix + "Compress.", this.Compress);
            this.SetParamObj(map, prefix + "Content.", this.Content);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "FilenameMode", this.FilenameMode);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "Progress", this.Progress);
            this.SetParamSimple(map, prefix + "RemainTime", this.RemainTime);
            this.SetParamSimple(map, prefix + "HistoryStatus", this.HistoryStatus);
            this.SetParamSimple(map, prefix + "StorageType", this.StorageType);
        }
    }
}

