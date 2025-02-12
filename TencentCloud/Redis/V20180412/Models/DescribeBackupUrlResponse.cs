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

namespace TencentCloud.Redis.V20180412.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeBackupUrlResponse : AbstractModel
    {
        
        /// <summary>
        /// 外网下载地址（6小时内链接有效），该字段正在逐步废弃中。
        /// </summary>
        [JsonProperty("DownloadUrl")]
        public string[] DownloadUrl{ get; set; }

        /// <summary>
        /// 内网下载地址（6小时内链接有效），该字段正在逐步废弃中。
        /// </summary>
        [JsonProperty("InnerDownloadUrl")]
        public string[] InnerDownloadUrl{ get; set; }

        /// <summary>
        /// 文件名称，该字段正在逐步废弃中。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Filenames")]
        public string[] Filenames{ get; set; }

        /// <summary>
        /// 备份文件信息列表。
        /// </summary>
        [JsonProperty("BackupInfos")]
        public BackupDownloadInfo[] BackupInfos{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "DownloadUrl.", this.DownloadUrl);
            this.SetParamArraySimple(map, prefix + "InnerDownloadUrl.", this.InnerDownloadUrl);
            this.SetParamArraySimple(map, prefix + "Filenames.", this.Filenames);
            this.SetParamArrayObj(map, prefix + "BackupInfos.", this.BackupInfos);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

