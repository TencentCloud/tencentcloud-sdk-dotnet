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

namespace TencentCloud.Cme.V20191029.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class VODExportInfo : AbstractModel
    {
        
        /// <summary>
        /// 导出的媒资名称。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 导出的媒资分类 Id。
        /// </summary>
        [JsonProperty("ClassId")]
        public ulong? ClassId{ get; set; }

        /// <summary>
        /// 第三方平台发布信息列表。暂未正式对外，请勿使用。
        /// </summary>
        [JsonProperty("ThirdPartyPublishInfos")]
        public ThirdPartyPublishInfo[] ThirdPartyPublishInfos{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "ClassId", this.ClassId);
            this.SetParamArrayObj(map, prefix + "ThirdPartyPublishInfos.", this.ThirdPartyPublishInfos);
        }
    }
}

