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

namespace TencentCloud.Cbs.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifySnapshotsSharePermissionRequest : AbstractModel
    {
        
        /// <summary>
        /// 接收分享快照的账号Id列表，array型参数的格式可以参考[API简介](https://cloud.tencent.com/document/api/213/568)。帐号ID不同于QQ号，查询用户帐号ID请查看[帐号信息](https://console.cloud.tencent.com/developer)中的帐号ID栏。
        /// </summary>
        [JsonProperty("AccountIds")]
        public string[] AccountIds{ get; set; }

        /// <summary>
        /// 操作，包括 SHARE，CANCEL。其中SHARE代表分享操作，CANCEL代表取消分享操作。
        /// </summary>
        [JsonProperty("Permission")]
        public string Permission{ get; set; }

        /// <summary>
        /// 快照ID, 可通过[DescribeSnapshots](https://cloud.tencent.com/document/api/362/15647)查询获取。
        /// </summary>
        [JsonProperty("SnapshotIds")]
        public string[] SnapshotIds{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "AccountIds.", this.AccountIds);
            this.SetParamSimple(map, prefix + "Permission", this.Permission);
            this.SetParamArraySimple(map, prefix + "SnapshotIds.", this.SnapshotIds);
        }
    }
}

