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
        /// <p>投递规则ID</p>
        /// </summary>
        [JsonProperty("ShipperId")]
        public string ShipperId{ get; set; }

        /// <summary>
        /// <p>日志主题ID</p>
        /// </summary>
        [JsonProperty("TopicId")]
        public string TopicId{ get; set; }

        /// <summary>
        /// <p>投递的bucket地址</p>
        /// </summary>
        [JsonProperty("Bucket")]
        public string Bucket{ get; set; }

        /// <summary>
        /// <p>投递的前缀目录</p>
        /// </summary>
        [JsonProperty("Prefix")]
        public string Prefix{ get; set; }

        /// <summary>
        /// <p>投递规则的名字</p>
        /// </summary>
        [JsonProperty("ShipperName")]
        public string ShipperName{ get; set; }

        /// <summary>
        /// <p>投递的时间间隔，单位 秒</p>
        /// </summary>
        [JsonProperty("Interval")]
        public ulong? Interval{ get; set; }

        /// <summary>
        /// <p>投递的文件的最大值，单位 MB</p>
        /// </summary>
        [JsonProperty("MaxSize")]
        public ulong? MaxSize{ get; set; }

        /// <summary>
        /// <p>是否生效</p>
        /// </summary>
        [JsonProperty("Status")]
        public bool? Status{ get; set; }

        /// <summary>
        /// <p>投递日志的过滤规则</p>
        /// </summary>
        [JsonProperty("FilterRules")]
        public FilterRuleInfo[] FilterRules{ get; set; }

        /// <summary>
        /// <p>投递日志的分区规则，支持strftime的时间格式表示</p>
        /// </summary>
        [JsonProperty("Partition")]
        public string Partition{ get; set; }

        /// <summary>
        /// <p>投递日志的压缩配置</p>
        /// </summary>
        [JsonProperty("Compress")]
        public CompressInfo Compress{ get; set; }

        /// <summary>
        /// <p>投递日志的内容格式配置</p>
        /// </summary>
        [JsonProperty("Content")]
        public ContentInfo Content{ get; set; }

        /// <summary>
        /// <p>投递日志的创建时间。格式：YYYY-MM-DD HH:MM:SS</p>
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// <p>投递文件命名配置，0：随机数命名，1：投递时间命名，默认0（随机数命名）</p>
        /// </summary>
        [JsonProperty("FilenameMode")]
        public ulong? FilenameMode{ get; set; }

        /// <summary>
        /// <p>投递数据范围的开始时间点</p>
        /// </summary>
        [JsonProperty("StartTime")]
        public long? StartTime{ get; set; }

        /// <summary>
        /// <p>投递数据范围的结束时间点</p>
        /// </summary>
        [JsonProperty("EndTime")]
        public long? EndTime{ get; set; }

        /// <summary>
        /// <p>历史数据投递的进度（仅当用户选择的数据内中历史数据时才有效）</p>
        /// </summary>
        [JsonProperty("Progress")]
        public float? Progress{ get; set; }

        /// <summary>
        /// <p>历史数据全部投递完成剩余的时间（仅当用户选择的数据中有历史数据时才有效）</p><p>单位：秒</p>
        /// </summary>
        [JsonProperty("RemainTime")]
        public long? RemainTime{ get; set; }

        /// <summary>
        /// <p>历史任务状态：<br>0：实时任务<br>1：任务准备中<br>2：任务运行中<br>3：任务运行异常<br>4：任务运行结束</p>
        /// </summary>
        [JsonProperty("HistoryStatus")]
        public long? HistoryStatus{ get; set; }

        /// <summary>
        /// <p>对象存储类型，默认值为 STANDARD。枚举值请参见<a href="https://cloud.tencent.com/document/product/436/33417"> 存储类型概述</a> 文档。<br>参考值有：<br>STANDARD：标准存储<br>STANDARD_IA：低频存储<br>ARCHIVE：归档存储<br>DEEP_ARCHIVE：深度归档存储<br>MAZ_STANDARD：标准存储（多 AZ）<br>MAZ_STANDARD_IA：低频存储（多 AZ）<br>INTELLIGENT_TIERING：智能分层存储<br>MAZ_INTELLIGENT_TIERING：智能分层存储（多 AZ）</p>
        /// </summary>
        [JsonProperty("StorageType")]
        public string StorageType{ get; set; }

        /// <summary>
        /// <p>角色访问描述名 <a href="https://cloud.tencent.com/document/product/598/19381">创建角色</a></p>
        /// </summary>
        [JsonProperty("RoleArn")]
        public string RoleArn{ get; set; }

        /// <summary>
        /// <p>外部ID</p>
        /// </summary>
        [JsonProperty("ExternalId")]
        public string ExternalId{ get; set; }

        /// <summary>
        /// <p>任务运行状态。支持<code>0</code>,<code>1</code>,<code>2</code></p><ul><li><code>0</code>: 停止</li><li><code>1</code>: 运行中</li><li><code>2</code>: 异常</li></ul>
        /// </summary>
        [JsonProperty("TaskStatus")]
        public ulong? TaskStatus{ get; set; }


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
            this.SetParamSimple(map, prefix + "RoleArn", this.RoleArn);
            this.SetParamSimple(map, prefix + "ExternalId", this.ExternalId);
            this.SetParamSimple(map, prefix + "TaskStatus", this.TaskStatus);
        }
    }
}

