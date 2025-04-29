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

namespace TencentCloud.Postgres.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyBackupDownloadRestrictionRequest : AbstractModel
    {
        
        /// <summary>
        /// 备份文件下载限制类型，NONE 无限制，内外网都可以下载；INTRANET 只允许内网下载；CUSTOMIZE 自定义限制下载的vpc或ip。
        /// </summary>
        [JsonProperty("RestrictionType")]
        public string RestrictionType{ get; set; }

        /// <summary>
        /// vpc限制效力，ALLOW 允许；DENY 拒绝。
        /// </summary>
        [JsonProperty("VpcRestrictionEffect")]
        public string VpcRestrictionEffect{ get; set; }

        /// <summary>
        /// 允许或拒绝下载备份文件的vpcId列表。
        /// **注意：**该入参会全量替换存量已有集合，非增量更新。修改需传入预期的全量集合。
        /// </summary>
        [JsonProperty("VpcIdSet")]
        public string[] VpcIdSet{ get; set; }

        /// <summary>
        /// ip限制效力，ALLOW 允许；DENY 拒绝。
        /// </summary>
        [JsonProperty("IpRestrictionEffect")]
        public string IpRestrictionEffect{ get; set; }

        /// <summary>
        /// 允许或拒绝下载备份文件的ip列表。
        /// **注意：**该入参会全量替换存量已有集合，非增量更新。修改需传入预期的全量集合。
        /// </summary>
        [JsonProperty("IpSet")]
        public string[] IpSet{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RestrictionType", this.RestrictionType);
            this.SetParamSimple(map, prefix + "VpcRestrictionEffect", this.VpcRestrictionEffect);
            this.SetParamArraySimple(map, prefix + "VpcIdSet.", this.VpcIdSet);
            this.SetParamSimple(map, prefix + "IpRestrictionEffect", this.IpRestrictionEffect);
            this.SetParamArraySimple(map, prefix + "IpSet.", this.IpSet);
        }
    }
}

