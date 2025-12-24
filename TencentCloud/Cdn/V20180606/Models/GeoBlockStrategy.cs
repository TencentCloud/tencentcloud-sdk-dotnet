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

namespace TencentCloud.Cdn.V20180606.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class GeoBlockStrategy : AbstractModel
    {
        
        /// <summary>
        /// 规则类型
        /// whitelist: 白名单
        /// blacklist: 黑名单
        /// </summary>
        [JsonProperty("BlockType")]
        public string BlockType{ get; set; }

        /// <summary>
        /// 生效规则
        /// </summary>
        [JsonProperty("RulePaths")]
        public string[] RulePaths{ get; set; }

        /// <summary>
        /// 生效类型
        /// all: 全部
        /// directory: 目录
        /// </summary>
        [JsonProperty("RuleType")]
        public string RuleType{ get; set; }

        /// <summary>
        /// 生效区域，可选值有: CN-AH CN-BJ CN-CQ CN-FJ CN-GD CN-GS CN-GX CN-GZ CN-HA CN-HB CN-HE CN-HI CN-HK CN-HL CN-HN CN-JL CN-JS CN-JX CN-LN CN-MO CN-NM CN-NX CN-QH CN-SC CN-SD CN-SH CN-SN CN-SX CN-TJ CN-TW CN-XJ CN-XZ CN-YN CN-ZJ AF AX AL DZ AS AD AO AI AQ AG AR AM AW AU AT AZ BS BH BD BB BY BE BZ BJ BM BT BO BQ BA BW BV BR IO BN BG BF BI CV KH CM CA KY CF TD CL CN CX CC CO KM CG CD CK CR CI HR CU CW CY CZ DK DJ DM DO EC EG SV GQ ER EE SZ ET FK FO FJ FI FR GF PF TF GA GM GE DE GH GI GR GL GD GP GU GT GG GN GW GY HT HM VA HN HK HU IS IN ID IR IQ IE IM IL IT JM JP JE JO KZ KE KI KP KR KW KG LA LV LB LS LR LY LI LT LU MO MG MW MY MV ML MT MH MQ MR MU YT MX FM MD MC MN ME MS MA MZ MM NA NR NP NL NC NZ NI NE NG NU NF MK MP NO OM PK PW PS PA PG PY PE PH PN PL PT PR QA RE RO RU RW BL SH KN LC MF PM VC WS SM ST SA SN RS SC SL SG SX SK SI SB SO ZA GS SS ES LK SD SR SJ SE CH SY TW TJ TZ TH TL TG TK TO TT TN TR TM TC TV UG UA AE GB US UM UY UZ VU VE VN VG VI WF EH YE ZM ZW
        /// </summary>
        [JsonProperty("Districts")]
        public string[] Districts{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "BlockType", this.BlockType);
            this.SetParamArraySimple(map, prefix + "RulePaths.", this.RulePaths);
            this.SetParamSimple(map, prefix + "RuleType", this.RuleType);
            this.SetParamArraySimple(map, prefix + "Districts.", this.Districts);
        }
    }
}

