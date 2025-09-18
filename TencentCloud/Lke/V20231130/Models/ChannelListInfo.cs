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

namespace TencentCloud.Lke.V20231130.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ChannelListInfo : AbstractModel
    {
        
        /// <summary>
        /// 渠道类型 10000 微信订阅号 10001 微信服务号 10002 企微应用
        /// </summary>
        [JsonProperty("ChannelType")]
        public ulong? ChannelType{ get; set; }

        /// <summary>
        /// 渠道状态 1未发布 2运行中 3已下线
        /// </summary>
        [JsonProperty("ChannelStatus")]
        public ulong? ChannelStatus{ get; set; }

        /// <summary>
        /// 渠道名称
        /// </summary>
        [JsonProperty("ChannelName")]
        public string ChannelName{ get; set; }

        /// <summary>
        /// 渠道id 数据库主键
        /// </summary>
        [JsonProperty("ChannelId")]
        public string ChannelId{ get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [JsonProperty("Comment")]
        public string Comment{ get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 最后更新人
        /// </summary>
        [JsonProperty("UpdatedUser")]
        public string UpdatedUser{ get; set; }

        /// <summary>
        /// 智能体应用可见范围，public-所有人可见 private-仅自己可见 share-通过分享可见
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("YuanQiInfo")]
        public YuanQi YuanQiInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ChannelType", this.ChannelType);
            this.SetParamSimple(map, prefix + "ChannelStatus", this.ChannelStatus);
            this.SetParamSimple(map, prefix + "ChannelName", this.ChannelName);
            this.SetParamSimple(map, prefix + "ChannelId", this.ChannelId);
            this.SetParamSimple(map, prefix + "Comment", this.Comment);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdatedUser", this.UpdatedUser);
            this.SetParamObj(map, prefix + "YuanQiInfo.", this.YuanQiInfo);
        }
    }
}

