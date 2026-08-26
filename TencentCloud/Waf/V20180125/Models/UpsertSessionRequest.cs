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

namespace TencentCloud.Waf.V20180125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UpsertSessionRequest : AbstractModel
    {
        
        /// <summary>
        /// 域名
        /// 入参限制：必填，必须为合法域名格式
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// 会话来源位置
        /// 取值说明：get-从URL查询参数中提取，post-从POST Body中提取，cookie-从Cookie中提取，header-从HTTP Header中提取
        /// 入参限制：必填，取值范围为get/post/cookie/header
        /// </summary>
        [JsonProperty("Source")]
        public string Source{ get; set; }

        /// <summary>
        /// 提取类别
        /// 取值说明：location-按位置提取（使用StartOffset和EndOffset），match-按字符串匹配提取（使用KeyOrStartMat和EndMat），exact_key-按精准Key提取（使用Key字段）
        /// 入参限制：必填，取值范围为location/match/exact_key
        /// </summary>
        [JsonProperty("Category")]
        public string Category{ get; set; }

        /// <summary>
        /// 提取key或者起始匹配模式
        /// 入参限制：最长32个字符，不允许包含MongoDB注入字符
        /// 说明：当Category为match时，表示匹配的起始字符串；当Category为exact_key时，表示精确匹配的key名
        /// </summary>
        [JsonProperty("KeyOrStartMat")]
        public string KeyOrStartMat{ get; set; }

        /// <summary>
        /// 结束匹配模式
        /// 入参限制：必填，最长32个字符，不允许包含MongoDB注入字符
        /// 说明：当Category为match时，表示匹配的结束字符串
        /// </summary>
        [JsonProperty("EndMat")]
        public string EndMat{ get; set; }

        /// <summary>
        /// 起始偏移位置
        /// 入参限制：必填，整数字符串
        /// 约束条件：EndOffset不能小于StartOffset，且EndOffset-StartOffset+1不能超过256
        /// 说明：当Category为location时生效，表示从会话值中提取的起始字节位置
        /// </summary>
        [JsonProperty("StartOffset")]
        public string StartOffset{ get; set; }

        /// <summary>
        /// 结束偏移位置
        /// 入参限制：必填，整数字符串
        /// 约束条件：不能小于StartOffset，且EndOffset-StartOffset+1不能超过256
        /// 说明：当Category为location时生效，表示从会话值中提取的结束字节位置
        /// </summary>
        [JsonProperty("EndOffset")]
        public string EndOffset{ get; set; }

        /// <summary>
        /// 版本
        /// </summary>
        [JsonProperty("Edition")]
        public string Edition{ get; set; }

        /// <summary>
        /// 会话名称
        /// 说明：用于标识会话的可读名称
        /// </summary>
        [JsonProperty("SessionName")]
        public string SessionName{ get; set; }

        /// <summary>
        /// 会话ID
        /// 说明：传-1表示新增会话（系统自动生成ID），传已有ID表示更新该会话配置
        /// 约束条件：新增时每个域名最多10条会话规则
        /// </summary>
        [JsonProperty("SessionID")]
        public long? SessionID{ get; set; }

        /// <summary>
        /// 会话标识参数（精准匹配key）
        /// 入参限制：key中"."分隔的层级不超过2层
        /// 说明：当Category为exact_key时使用，表示要精确匹配的参数名
        /// </summary>
        [JsonProperty("Key")]
        public string Key{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamSimple(map, prefix + "Source", this.Source);
            this.SetParamSimple(map, prefix + "Category", this.Category);
            this.SetParamSimple(map, prefix + "KeyOrStartMat", this.KeyOrStartMat);
            this.SetParamSimple(map, prefix + "EndMat", this.EndMat);
            this.SetParamSimple(map, prefix + "StartOffset", this.StartOffset);
            this.SetParamSimple(map, prefix + "EndOffset", this.EndOffset);
            this.SetParamSimple(map, prefix + "Edition", this.Edition);
            this.SetParamSimple(map, prefix + "SessionName", this.SessionName);
            this.SetParamSimple(map, prefix + "SessionID", this.SessionID);
            this.SetParamSimple(map, prefix + "Key", this.Key);
        }
    }
}

