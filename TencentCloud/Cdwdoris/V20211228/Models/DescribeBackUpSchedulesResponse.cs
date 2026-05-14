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

    public class DescribeBackUpSchedulesResponse : AbstractModel
    {
        
        /// <summary>
        /// <p>备份是否开启</p>
        /// </summary>
        [JsonProperty("BackUpOpened")]
        public bool? BackUpOpened{ get; set; }

        /// <summary>
        /// <p>备份桶</p>
        /// </summary>
        [JsonProperty("CosBucketName")]
        public string CosBucketName{ get; set; }

        /// <summary>
        /// <p>备份的状态</p>
        /// </summary>
        [JsonProperty("BackUpStatus")]
        public long? BackUpStatus{ get; set; }

        /// <summary>
        /// <p>备份、迁移任务信息</p>
        /// </summary>
        [JsonProperty("BackupScheduleInfos")]
        public BackupScheduleInfo[] BackupScheduleInfos{ get; set; }

        /// <summary>
        /// <p>当前系统时间</p>
        /// </summary>
        [JsonProperty("CurrentTime")]
        public string CurrentTime{ get; set; }

        /// <summary>
        /// <p>桶加密状态信息</p>
        /// </summary>
        [JsonProperty("BucketEncryption")]
        public BucketEncryptionInfo BucketEncryption{ get; set; }

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
            this.SetParamSimple(map, prefix + "BackUpOpened", this.BackUpOpened);
            this.SetParamSimple(map, prefix + "CosBucketName", this.CosBucketName);
            this.SetParamSimple(map, prefix + "BackUpStatus", this.BackUpStatus);
            this.SetParamArrayObj(map, prefix + "BackupScheduleInfos.", this.BackupScheduleInfos);
            this.SetParamSimple(map, prefix + "CurrentTime", this.CurrentTime);
            this.SetParamObj(map, prefix + "BucketEncryption.", this.BucketEncryption);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

