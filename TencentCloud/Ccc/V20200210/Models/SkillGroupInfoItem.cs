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

namespace TencentCloud.Ccc.V20200210.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SkillGroupInfoItem : AbstractModel
    {
        
        /// <summary>
        /// 技能组ID
        /// </summary>
        [JsonProperty("SkillGroupId")]
        public long? SkillGroupId{ get; set; }

        /// <summary>
        /// 技能组名称
        /// </summary>
        [JsonProperty("SkillGroupName")]
        public string SkillGroupName{ get; set; }

        /// <summary>
        /// （废弃）类型：IM、TEL、ALL（全媒体）
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 会话分配策略
        /// </summary>
        [JsonProperty("RoutePolicy")]
        public string RoutePolicy{ get; set; }

        /// <summary>
        /// 会话分配是否优先上次服务座席
        /// </summary>
        [JsonProperty("UsingLastSeat")]
        public long? UsingLastSeat{ get; set; }

        /// <summary>
        /// 单客服最大并发数（电话类型默认1）
        /// </summary>
        [JsonProperty("MaxConcurrency")]
        public long? MaxConcurrency{ get; set; }

        /// <summary>
        /// 最后修改时间
        /// </summary>
        [JsonProperty("LastModifyTimestamp")]
        public long? LastModifyTimestamp{ get; set; }

        /// <summary>
        /// 技能组类型0-电话，1-在线，3-音频，4-视频	
        /// </summary>
        [JsonProperty("SkillGroupType")]
        public long? SkillGroupType{ get; set; }

        /// <summary>
        /// 技能组内线号码
        /// </summary>
        [JsonProperty("Alias")]
        public string Alias{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SkillGroupId", this.SkillGroupId);
            this.SetParamSimple(map, prefix + "SkillGroupName", this.SkillGroupName);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "RoutePolicy", this.RoutePolicy);
            this.SetParamSimple(map, prefix + "UsingLastSeat", this.UsingLastSeat);
            this.SetParamSimple(map, prefix + "MaxConcurrency", this.MaxConcurrency);
            this.SetParamSimple(map, prefix + "LastModifyTimestamp", this.LastModifyTimestamp);
            this.SetParamSimple(map, prefix + "SkillGroupType", this.SkillGroupType);
            this.SetParamSimple(map, prefix + "Alias", this.Alias);
        }
    }
}

