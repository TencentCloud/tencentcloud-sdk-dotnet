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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AccessKeyRisk : AbstractModel
    {
        
        /// <summary>
        /// 风险名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 风险等级
        /// 0-无效 1-提示 2-低危 3-中危 4-高危 5-严重
        /// </summary>
        [JsonProperty("Level")]
        public long? Level{ get; set; }

        /// <summary>
        /// 风险记录ID
        /// </summary>
        [JsonProperty("ID")]
        public long? ID{ get; set; }

        /// <summary>
        /// 风险规则ID
        /// </summary>
        [JsonProperty("RiskRuleID")]
        public long? RiskRuleID{ get; set; }

        /// <summary>
        /// 风险类型
        /// 0-配置风险
        /// </summary>
        [JsonProperty("RiskType")]
        public long? RiskType{ get; set; }

        /// <summary>
        /// 访问密钥
        /// </summary>
        [JsonProperty("AccessKey")]
        public string AccessKey{ get; set; }

        /// <summary>
        /// 访问密钥ID
        /// </summary>
        [JsonProperty("AccessKeyID")]
        public ulong? AccessKeyID{ get; set; }

        /// <summary>
        /// 访问密钥备注
        /// </summary>
        [JsonProperty("AccessKeyRemark")]
        public string AccessKeyRemark{ get; set; }

        /// <summary>
        /// 风险检出时间
        /// </summary>
        [JsonProperty("RiskTime")]
        public string RiskTime{ get; set; }

        /// <summary>
        /// 风险状态
        /// 0-未处理 2-已忽略 3-已收敛
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// 风险标签
        /// </summary>
        [JsonProperty("Tag")]
        public string[] Tag{ get; set; }

        /// <summary>
        /// 风险证据
        /// </summary>
        [JsonProperty("Evidence")]
        public string Evidence{ get; set; }

        /// <summary>
        /// 风险描述
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 所属主账号Uin
        /// </summary>
        [JsonProperty("Uin")]
        public string Uin{ get; set; }

        /// <summary>
        /// 所属主账号昵称
        /// </summary>
        [JsonProperty("Nickname")]
        public string Nickname{ get; set; }

        /// <summary>
        /// 所属子账号Uin
        /// </summary>
        [JsonProperty("SubUin")]
        public string SubUin{ get; set; }

        /// <summary>
        /// 所属子账号昵称
        /// </summary>
        [JsonProperty("SubNickname")]
        public string SubNickname{ get; set; }

        /// <summary>
        /// 账号类型
        /// 0 主账号AK 1子账号AK
        /// 2 临时密钥
        /// </summary>
        [JsonProperty("Type")]
        public long? Type{ get; set; }

        /// <summary>
        /// 检测状态
        /// 0表示 已检测
        /// 1表示 检测中
        /// </summary>
        [JsonProperty("CheckStatus")]
        public long? CheckStatus{ get; set; }

        /// <summary>
        /// 所属appid
        /// </summary>
        [JsonProperty("AppID")]
        public long? AppID{ get; set; }

        /// <summary>
        /// 对应风险的查询参数
        /// </summary>
        [JsonProperty("QueryParam")]
        public string QueryParam{ get; set; }

        /// <summary>
        /// 云类型 0-腾讯云 4-阿里云
        /// </summary>
        [JsonProperty("CloudType")]
        public long? CloudType{ get; set; }

        /// <summary>
        /// 相关的AK列表，包含AK名和AK备注
        /// </summary>
        [JsonProperty("RelatedAK")]
        public AKInfo[] RelatedAK{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Level", this.Level);
            this.SetParamSimple(map, prefix + "ID", this.ID);
            this.SetParamSimple(map, prefix + "RiskRuleID", this.RiskRuleID);
            this.SetParamSimple(map, prefix + "RiskType", this.RiskType);
            this.SetParamSimple(map, prefix + "AccessKey", this.AccessKey);
            this.SetParamSimple(map, prefix + "AccessKeyID", this.AccessKeyID);
            this.SetParamSimple(map, prefix + "AccessKeyRemark", this.AccessKeyRemark);
            this.SetParamSimple(map, prefix + "RiskTime", this.RiskTime);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamArraySimple(map, prefix + "Tag.", this.Tag);
            this.SetParamSimple(map, prefix + "Evidence", this.Evidence);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "Uin", this.Uin);
            this.SetParamSimple(map, prefix + "Nickname", this.Nickname);
            this.SetParamSimple(map, prefix + "SubUin", this.SubUin);
            this.SetParamSimple(map, prefix + "SubNickname", this.SubNickname);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "CheckStatus", this.CheckStatus);
            this.SetParamSimple(map, prefix + "AppID", this.AppID);
            this.SetParamSimple(map, prefix + "QueryParam", this.QueryParam);
            this.SetParamSimple(map, prefix + "CloudType", this.CloudType);
            this.SetParamArrayObj(map, prefix + "RelatedAK.", this.RelatedAK);
        }
    }
}

