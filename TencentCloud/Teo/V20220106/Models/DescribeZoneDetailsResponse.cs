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

namespace TencentCloud.Teo.V20220106.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeZoneDetailsResponse : AbstractModel
    {
        
        /// <summary>
        /// 站点 ID
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }

        /// <summary>
        /// 站点名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 用户当前使用的 NS 列表
        /// </summary>
        [JsonProperty("OriginalNameServers")]
        public string[] OriginalNameServers{ get; set; }

        /// <summary>
        /// 腾讯云分配给用户的 NS 列表
        /// </summary>
        [JsonProperty("NameServers")]
        public string[] NameServers{ get; set; }

        /// <summary>
        /// 站点状态
        /// - active：NS 已切换
        /// - pending：NS 未切换
        /// - moved：NS 已切走
        /// - deactivated：被封禁
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 站点接入方式
        /// - full：NS 接入
        /// - partial：CNAME 接入
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 站点是否关闭
        /// </summary>
        [JsonProperty("Paused")]
        public bool? Paused{ get; set; }

        /// <summary>
        /// 是否开启 CNAME 加速
        /// - enabled：开启
        /// - disabled：关闭
        /// </summary>
        [JsonProperty("CnameSpeedUp")]
        public string CnameSpeedUp{ get; set; }

        /// <summary>
        /// cname切换验证状态
        /// - finished 切换完成
        /// - pending 切换验证中
        /// </summary>
        [JsonProperty("CnameStatus")]
        public string CnameStatus{ get; set; }

        /// <summary>
        /// 资源标签
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// 站点接入地域，取值为：
        /// <li> global：全球；</li>
        /// <li> mainland：中国大陆；</li>
        /// <li> overseas：境外区域。</li>
        /// </summary>
        [JsonProperty("Area")]
        public string Area{ get; set; }

        /// <summary>
        /// 计费资源
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Resources")]
        public Resource[] Resources{ get; set; }

        /// <summary>
        /// 站点修改时间
        /// </summary>
        [JsonProperty("ModifiedOn")]
        public string ModifiedOn{ get; set; }

        /// <summary>
        /// 站点创建时间
        /// </summary>
        [JsonProperty("CreatedOn")]
        public string CreatedOn{ get; set; }

        /// <summary>
        /// 用户自定义 NS 信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("VanityNameServers")]
        public VanityNameServers VanityNameServers{ get; set; }

        /// <summary>
        /// 用户自定义 NS IP 信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("VanityNameServersIps")]
        public VanityNameServersIps[] VanityNameServersIps{ get; set; }

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
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamArraySimple(map, prefix + "OriginalNameServers.", this.OriginalNameServers);
            this.SetParamArraySimple(map, prefix + "NameServers.", this.NameServers);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Paused", this.Paused);
            this.SetParamSimple(map, prefix + "CnameSpeedUp", this.CnameSpeedUp);
            this.SetParamSimple(map, prefix + "CnameStatus", this.CnameStatus);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "Area", this.Area);
            this.SetParamArrayObj(map, prefix + "Resources.", this.Resources);
            this.SetParamSimple(map, prefix + "ModifiedOn", this.ModifiedOn);
            this.SetParamSimple(map, prefix + "CreatedOn", this.CreatedOn);
            this.SetParamObj(map, prefix + "VanityNameServers.", this.VanityNameServers);
            this.SetParamArrayObj(map, prefix + "VanityNameServersIps.", this.VanityNameServersIps);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

