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

namespace TencentCloud.Ioa.V20220601.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SoftwareInformationData : AbstractModel
    {
        
        /// <summary>
        /// 软件名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 安装时间
        /// </summary>
        [JsonProperty("InstallDate")]
        public string InstallDate{ get; set; }

        /// <summary>
        /// 软件列表id(只支持32位)
        /// </summary>
        [JsonProperty("SoftwareId")]
        public long? SoftwareId{ get; set; }

        /// <summary>
        /// 唯一标识Mid
        /// </summary>
        [JsonProperty("Mid")]
        public string Mid{ get; set; }

        /// <summary>
        /// 软件版本
        /// </summary>
        [JsonProperty("Version")]
        public string Version{ get; set; }

        /// <summary>
        /// 公司名
        /// </summary>
        [JsonProperty("CorpName")]
        public string CorpName{ get; set; }

        /// <summary>
        /// 列表Id(只支持32位)
        /// </summary>
        [JsonProperty("Id")]
        public long? Id{ get; set; }

        /// <summary>
        /// 盗版风险（0:未支持，1:风险，2:未发现，3:未开启）
        /// </summary>
        [JsonProperty("PiracyRisk")]
        public long? PiracyRisk{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "InstallDate", this.InstallDate);
            this.SetParamSimple(map, prefix + "SoftwareId", this.SoftwareId);
            this.SetParamSimple(map, prefix + "Mid", this.Mid);
            this.SetParamSimple(map, prefix + "Version", this.Version);
            this.SetParamSimple(map, prefix + "CorpName", this.CorpName);
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "PiracyRisk", this.PiracyRisk);
        }
    }
}

