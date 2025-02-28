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

namespace TencentCloud.Cdwdoris.V20211228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ClusterConfigsHistory : AbstractModel
    {
        
        /// <summary>
        /// 计算组id
        /// </summary>
        [JsonProperty("ComputeGroupId")]
        public string ComputeGroupId{ get; set; }

        /// <summary>
        /// 配置文件名称
        /// </summary>
        [JsonProperty("FileName")]
        public string FileName{ get; set; }

        /// <summary>
        /// 修改后的配置文件内容，base64编码
        /// </summary>
        [JsonProperty("NewConfValue")]
        public string NewConfValue{ get; set; }

        /// <summary>
        /// 修改前的配置文件内容，base64编码
        /// </summary>
        [JsonProperty("OldConfValue")]
        public string OldConfValue{ get; set; }

        /// <summary>
        /// 修改原因
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        [JsonProperty("ModifyTime")]
        public string ModifyTime{ get; set; }

        /// <summary>
        /// 修改子账号id
        /// </summary>
        [JsonProperty("UserUin")]
        public string UserUin{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ComputeGroupId", this.ComputeGroupId);
            this.SetParamSimple(map, prefix + "FileName", this.FileName);
            this.SetParamSimple(map, prefix + "NewConfValue", this.NewConfValue);
            this.SetParamSimple(map, prefix + "OldConfValue", this.OldConfValue);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "ModifyTime", this.ModifyTime);
            this.SetParamSimple(map, prefix + "UserUin", this.UserUin);
        }
    }
}

