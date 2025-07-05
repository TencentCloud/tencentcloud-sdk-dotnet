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

    public class CreateShipperRequest : AbstractModel
    {
        
        /// <summary>
        /// 创建的投递规则所属的日志主题ID
        /// </summary>
        [JsonProperty("TopicId")]
        public string TopicId{ get; set; }

        /// <summary>
        /// COS存储桶，详见产品支持的[存储桶命名规范](https://cloud.tencent.com/document/product/436/13312)。
        /// </summary>
        [JsonProperty("Bucket")]
        public string Bucket{ get; set; }

        /// <summary>
        /// 投递规则投递的新的目录前缀。
        /// - 仅支持0-9A-Za-z-_/
        /// - 最大支持256个字符
        /// </summary>
        [JsonProperty("Prefix")]
        public string Prefix{ get; set; }

        /// <summary>
        /// 投递规则的名字
        /// </summary>
        [JsonProperty("ShipperName")]
        public string ShipperName{ get; set; }

        /// <summary>
        /// 投递的时间间隔，单位 秒，默认300，范围 300-900
        /// </summary>
        [JsonProperty("Interval")]
        public ulong? Interval{ get; set; }

        /// <summary>
        /// 投递的文件的最大值，单位 MB，默认256，范围 5-256
        /// </summary>
        [JsonProperty("MaxSize")]
        public ulong? MaxSize{ get; set; }

        /// <summary>
        /// 投递日志的过滤规则，匹配的日志进行投递，各rule之间是and关系，最多5个，数组为空则表示不过滤而全部投递
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
        /// 投递文件命名配置，0：随机数命名，1：投递时间命名，默认0（随机数命名）
        /// </summary>
        [JsonProperty("FilenameMode")]
        public ulong? FilenameMode{ get; set; }

        /// <summary>
        /// 投递数据范围的开始时间点（秒级时间戳），不能超出日志主题的生命周期起点。
        /// 如果用户不填写，默认为用户新建投递任务的时间。
        /// </summary>
        [JsonProperty("StartTime")]
        public long? StartTime{ get; set; }

        /// <summary>
        /// 投递数据范围的结束时间点（秒级时间戳），不能填写未来时间。
        /// 如果用户不填写，默认为持续投递，即无限。
        /// </summary>
        [JsonProperty("EndTime")]
        public long? EndTime{ get; set; }

        /// <summary>
        /// cos桶存储类型。支持：STANDARD_IA、ARCHIVE、DEEP_ARCHIVE、STANDARD、MAZ_STANDARD、MAZ_STANDARD_IA、INTELLIGENT_TIERING。
        /// 
        /// 1. STANDARD_IA：低频存储；
        /// 2. ARCHIVE：归档存储；
        /// 3. DEEP_ARCHIVE：深度归档存储；
        /// 4. STANDARD：标准存储；
        /// 5. MAZ_STANDARD：标准存储（多 AZ）；
        /// 6. MAZ_STANDARD_IA：低频存储（多 AZ）；
        /// 7. INTELLIGENT_TIERING：智能分层存储。
        /// </summary>
        [JsonProperty("StorageType")]
        public string StorageType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TopicId", this.TopicId);
            this.SetParamSimple(map, prefix + "Bucket", this.Bucket);
            this.SetParamSimple(map, prefix + "Prefix", this.Prefix);
            this.SetParamSimple(map, prefix + "ShipperName", this.ShipperName);
            this.SetParamSimple(map, prefix + "Interval", this.Interval);
            this.SetParamSimple(map, prefix + "MaxSize", this.MaxSize);
            this.SetParamArrayObj(map, prefix + "FilterRules.", this.FilterRules);
            this.SetParamSimple(map, prefix + "Partition", this.Partition);
            this.SetParamObj(map, prefix + "Compress.", this.Compress);
            this.SetParamObj(map, prefix + "Content.", this.Content);
            this.SetParamSimple(map, prefix + "FilenameMode", this.FilenameMode);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "StorageType", this.StorageType);
        }
    }
}

