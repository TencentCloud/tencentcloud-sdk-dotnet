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

namespace TencentCloud.Cdb.V20170320.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeBinlogBackupOverviewResponse : AbstractModel
    {
        
        /// <summary>
        /// 总的日志备份容量，包含异地日志备份（单位为字节）。
        /// </summary>
        [JsonProperty("BinlogBackupVolume")]
        public long? BinlogBackupVolume{ get; set; }

        /// <summary>
        /// 总的日志备份个数，包含异地日志备份。
        /// </summary>
        [JsonProperty("BinlogBackupCount")]
        public long? BinlogBackupCount{ get; set; }

        /// <summary>
        /// 异地日志备份容量（单位为字节）。
        /// </summary>
        [JsonProperty("RemoteBinlogVolume")]
        public long? RemoteBinlogVolume{ get; set; }

        /// <summary>
        /// 异地日志备份个数。
        /// </summary>
        [JsonProperty("RemoteBinlogCount")]
        public long? RemoteBinlogCount{ get; set; }

        /// <summary>
        /// 归档日志备份容量（单位为字节）。
        /// </summary>
        [JsonProperty("BinlogArchiveVolume")]
        public long? BinlogArchiveVolume{ get; set; }

        /// <summary>
        /// 归档日志备份个数。
        /// </summary>
        [JsonProperty("BinlogArchiveCount")]
        public long? BinlogArchiveCount{ get; set; }

        /// <summary>
        /// 标准存储日志备份容量（单位为字节）。
        /// </summary>
        [JsonProperty("BinlogStandbyVolume")]
        public long? BinlogStandbyVolume{ get; set; }

        /// <summary>
        /// 标准存储日志备份个数。
        /// </summary>
        [JsonProperty("BinlogStandbyCount")]
        public long? BinlogStandbyCount{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "BinlogBackupVolume", this.BinlogBackupVolume);
            this.SetParamSimple(map, prefix + "BinlogBackupCount", this.BinlogBackupCount);
            this.SetParamSimple(map, prefix + "RemoteBinlogVolume", this.RemoteBinlogVolume);
            this.SetParamSimple(map, prefix + "RemoteBinlogCount", this.RemoteBinlogCount);
            this.SetParamSimple(map, prefix + "BinlogArchiveVolume", this.BinlogArchiveVolume);
            this.SetParamSimple(map, prefix + "BinlogArchiveCount", this.BinlogArchiveCount);
            this.SetParamSimple(map, prefix + "BinlogStandbyVolume", this.BinlogStandbyVolume);
            this.SetParamSimple(map, prefix + "BinlogStandbyCount", this.BinlogStandbyCount);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

