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

namespace TencentCloud.Goosefs.V20220519.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class MappedBucket : AbstractModel
    {
        
        /// <summary>
        /// 对象存储Bucket名
        /// </summary>
        [JsonProperty("BucketName")]
        public string BucketName{ get; set; }

        /// <summary>
        /// 映射到的文件系统路径, 默认为/
        /// </summary>
        [JsonProperty("FileSystemPath")]
        public string FileSystemPath{ get; set; }

        /// <summary>
        /// 数据流动的自动策略, 包含加载与沉降。策略可以是多种的组合
        /// 按需加载(OnDemandImport)
        /// 自动加载元数据(AutoImportMeta)
        /// 自动加载数据(AutoImportData)
        /// 周期加载(PeriodImport)
        /// 
        /// 周期沉降(PeriodExport)
        /// 立即沉降(ImmediateExport)
        /// </summary>
        [JsonProperty("DataRepositoryTaskAutoStrategy")]
        public string[] DataRepositoryTaskAutoStrategy{ get; set; }

        /// <summary>
        /// 绑定bucket的数据流动策略ID
        /// </summary>
        [JsonProperty("RuleId")]
        public string RuleId{ get; set; }

        /// <summary>
        /// 规则备注与描述
        /// </summary>
        [JsonProperty("RuleDescription")]
        public string RuleDescription{ get; set; }

        /// <summary>
        /// 桶关联状态 0：关联中 1：关联完成
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }

        /// <summary>
        /// 是否使用全球加速域名
        /// </summary>
        [JsonProperty("AccelerateFlag")]
        public bool? AccelerateFlag{ get; set; }

        /// <summary>
        /// 桶所在的园区
        /// </summary>
        [JsonProperty("BucketRegion")]
        public string BucketRegion{ get; set; }

        /// <summary>
        /// 自定义Endpoint
        /// </summary>
        [JsonProperty("Endpoint")]
        public string Endpoint{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "BucketName", this.BucketName);
            this.SetParamSimple(map, prefix + "FileSystemPath", this.FileSystemPath);
            this.SetParamArraySimple(map, prefix + "DataRepositoryTaskAutoStrategy.", this.DataRepositoryTaskAutoStrategy);
            this.SetParamSimple(map, prefix + "RuleId", this.RuleId);
            this.SetParamSimple(map, prefix + "RuleDescription", this.RuleDescription);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "AccelerateFlag", this.AccelerateFlag);
            this.SetParamSimple(map, prefix + "BucketRegion", this.BucketRegion);
            this.SetParamSimple(map, prefix + "Endpoint", this.Endpoint);
        }
    }
}

