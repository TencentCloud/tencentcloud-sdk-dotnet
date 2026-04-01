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

namespace TencentCloud.Tcbr.V20220217.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ServerBaseInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>服务名</p>
        /// </summary>
        [JsonProperty("ServerName")]
        public string ServerName{ get; set; }

        /// <summary>
        /// <p>默认服务域名</p>
        /// </summary>
        [JsonProperty("DefaultDomainName")]
        public string DefaultDomainName{ get; set; }

        /// <summary>
        /// <p>自定义域名</p>
        /// </summary>
        [JsonProperty("CustomDomainName")]
        public string CustomDomainName{ get; set; }

        /// <summary>
        /// <p>服务状态：creating/create_failed/freezing/freeze_fail/froze/unfreezing/unfreeze_fail/normal/deleting/delete_failed/abnormal</p><p>枚举值：</p><ul><li>creating： 创建中</li><li>create_failed： 创建失败</li><li>freezing： 冻结中</li><li>freeze_fail： 冻结失败</li><li>froze： 已冻结</li><li>unfreezing： 解冻中</li><li>unfreeze_fail： 解冻失败</li><li>normal： 正常</li><li>deleting： 删除中</li><li>delete_failed： 删除失败</li><li>abnormal： 服务异常</li></ul>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// <p>更新时间</p>
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// <p>公网访问类型</p>
        /// </summary>
        [JsonProperty("AccessTypes")]
        public string[] AccessTypes{ get; set; }

        /// <summary>
        /// <p>展示自定义域名</p>
        /// </summary>
        [JsonProperty("CustomDomainNames")]
        public string[] CustomDomainNames{ get; set; }

        /// <summary>
        /// <p>服务类型: function 云函数2.0；container 容器服务</p>
        /// </summary>
        [JsonProperty("ServerType")]
        public string ServerType{ get; set; }

        /// <summary>
        /// <p>流量类型，目前只有 FLOW</p>
        /// </summary>
        [JsonProperty("TrafficType")]
        public string TrafficType{ get; set; }

        /// <summary>
        /// <p>创建时间</p>
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ServerName", this.ServerName);
            this.SetParamSimple(map, prefix + "DefaultDomainName", this.DefaultDomainName);
            this.SetParamSimple(map, prefix + "CustomDomainName", this.CustomDomainName);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamArraySimple(map, prefix + "AccessTypes.", this.AccessTypes);
            this.SetParamArraySimple(map, prefix + "CustomDomainNames.", this.CustomDomainNames);
            this.SetParamSimple(map, prefix + "ServerType", this.ServerType);
            this.SetParamSimple(map, prefix + "TrafficType", this.TrafficType);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
        }
    }
}

