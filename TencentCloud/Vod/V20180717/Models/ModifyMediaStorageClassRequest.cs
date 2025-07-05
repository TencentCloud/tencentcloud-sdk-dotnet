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

namespace TencentCloud.Vod.V20180717.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyMediaStorageClassRequest : AbstractModel
    {
        
        /// <summary>
        /// 媒体文件唯一标识列表，最大长度：100。
        /// </summary>
        [JsonProperty("FileIds")]
        public string[] FileIds{ get; set; }

        /// <summary>
        /// 目标存储类型。可选值有：
        /// <li> STANDARD：标准存储。</li>
        /// <li> STANDARD_IA：低频存储。</li>
        /// <li> ARCHIVE：归档存储。</li>
        /// <li> DEEP_ARCHIVE：深度归档存储。</li>
        /// </summary>
        [JsonProperty("StorageClass")]
        public string StorageClass{ get; set; }

        /// <summary>
        /// <b>点播[应用](/document/product/266/14574) ID。从2023年12月25日起开通点播的客户，如访问点播应用中的资源（无论是默认应用还是新创建的应用），必须将该字段填写为应用 ID。</b>
        /// </summary>
        [JsonProperty("SubAppId")]
        public ulong? SubAppId{ get; set; }

        /// <summary>
        /// 取回模式。当文件的存储类型从归档或深度归档转换为标准存储时，需要指定取回（也称为解冻）操作的模式，具体说明请参考[数据取回及取回模式](https://cloud.tencent.com/document/product/266/56196#retake)。
        /// 当媒体文件目前的存储类型为归档存储时，有以下取值：
        /// <li>Expedited：极速模式。</li>
        /// <li>Standard：标准模式。</li>
        /// <li>Bulk：批量模式。</li>
        /// 当媒体文件目前的存储类型为深度归档存储时，有以下取值：
        /// <li>Standard：标准模式。</li>
        /// <li>Bulk：批量模式。</li>
        /// </summary>
        [JsonProperty("RestoreTier")]
        public string RestoreTier{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "FileIds.", this.FileIds);
            this.SetParamSimple(map, prefix + "StorageClass", this.StorageClass);
            this.SetParamSimple(map, prefix + "SubAppId", this.SubAppId);
            this.SetParamSimple(map, prefix + "RestoreTier", this.RestoreTier);
        }
    }
}

