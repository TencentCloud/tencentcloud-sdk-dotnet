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

namespace TencentCloud.Cdwdoris.V20211228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class BackupCosInfo : AbstractModel
    {
        
        /// <summary>
        /// 备份文件所在的cos桶
        /// </summary>
        [JsonProperty("CosBucket")]
        public string CosBucket{ get; set; }

        /// <summary>
        /// 备份文件所在的完整cos路径
        /// </summary>
        [JsonProperty("CosPath")]
        public string CosPath{ get; set; }

        /// <summary>
        /// 备份文件名称
        /// </summary>
        [JsonProperty("SnapShotPath")]
        public string SnapShotPath{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CosBucket", this.CosBucket);
            this.SetParamSimple(map, prefix + "CosPath", this.CosPath);
            this.SetParamSimple(map, prefix + "SnapShotPath", this.SnapShotPath);
        }
    }
}

