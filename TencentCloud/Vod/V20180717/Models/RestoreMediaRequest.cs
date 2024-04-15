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

namespace TencentCloud.Vod.V20180717.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RestoreMediaRequest : AbstractModel
    {
        
        /// <summary>
        /// 媒体文件唯一标识列表，最大长度：100。
        /// </summary>
        [JsonProperty("FileIds")]
        public string[] FileIds{ get; set; }

        /// <summary>
        /// <b>点播[应用](/document/product/266/14574) ID。从2023年12月25日起开通点播的客户，如访问点播应用中的资源（无论是默认应用还是新创建的应用），必须将该字段填写为应用 ID。</b>
        /// </summary>
        [JsonProperty("SubAppId")]
        public ulong? SubAppId{ get; set; }

        /// <summary>
        /// 解冻出的临时媒体文件的可访问持续时长，必须大于0，单位为“天”。
        /// </summary>
        [JsonProperty("RestoreDay")]
        public ulong? RestoreDay{ get; set; }

        /// <summary>
        /// 解冻模式。当媒体文件当前的存储类型为归档存储时，有以下取值：
        /// <li>极速模式：Expedited，解冻任务在5分钟后完成。</li>
        /// <li>标准模式：Standard，解冻任务在5小时后完成 。</li>
        /// <li>批量模式：Bulk，，解冻任务在12小时后完成。</li>
        /// 当媒体文件的存储类型为深度归档存储时，有以下取值：
        /// <li>标准模式：Standard，解冻任务在24小时后完成。</li>
        /// <li>批量模式：Bulk，解冻任务在48小时后完成。</li>
        /// </summary>
        [JsonProperty("RestoreTier")]
        public string RestoreTier{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "FileIds.", this.FileIds);
            this.SetParamSimple(map, prefix + "SubAppId", this.SubAppId);
            this.SetParamSimple(map, prefix + "RestoreDay", this.RestoreDay);
            this.SetParamSimple(map, prefix + "RestoreTier", this.RestoreTier);
        }
    }
}

