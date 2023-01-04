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

    public class ModifyRemoteBackupConfigRequest : AbstractModel
    {
        
        /// <summary>
        /// 实例 ID，格式如：cdb-c1nl9rpv。与云数据库控制台页面中显示的实例 ID 相同。
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 异地数据备份开关，off - 关闭异地备份，on-开启异地备份
        /// </summary>
        [JsonProperty("RemoteBackupSave")]
        public string RemoteBackupSave{ get; set; }

        /// <summary>
        /// 异地日志备份开关，off - 关闭异地备份，on-开启异地备份，只有在参数RemoteBackupSave为on时，RemoteBinlogSave参数才可设置为on
        /// </summary>
        [JsonProperty("RemoteBinlogSave")]
        public string RemoteBinlogSave{ get; set; }

        /// <summary>
        /// 用户设置异地备份地域列表
        /// </summary>
        [JsonProperty("RemoteRegion")]
        public string[] RemoteRegion{ get; set; }

        /// <summary>
        /// 异地备份保留时间，单位为天
        /// </summary>
        [JsonProperty("ExpireDays")]
        public long? ExpireDays{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "RemoteBackupSave", this.RemoteBackupSave);
            this.SetParamSimple(map, prefix + "RemoteBinlogSave", this.RemoteBinlogSave);
            this.SetParamArraySimple(map, prefix + "RemoteRegion.", this.RemoteRegion);
            this.SetParamSimple(map, prefix + "ExpireDays", this.ExpireDays);
        }
    }
}

