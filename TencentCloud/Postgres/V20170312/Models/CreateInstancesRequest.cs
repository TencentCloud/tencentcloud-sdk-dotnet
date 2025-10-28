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

namespace TencentCloud.Postgres.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateInstancesRequest : AbstractModel
    {
        
        /// <summary>
        /// 实例所属主可用区， 如：ap-guangzhou-3；若需要支持多可用区，在DBNodeSet.N字段中进行添加主可用区和备可用区信息；
        /// 可用区信息可以通过调用 [DescribeZones](https://cloud.tencent.com/document/api/409/16769) 接口的返回值中的Zone字段来获取。
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// 售卖规格码。该参数可以通过调用[DescribeClasses](https://cloud.tencent.com/document/api/409/89019)的返回值中的SpecCode字段来获取。
        /// </summary>
        [JsonProperty("SpecCode")]
        public string SpecCode{ get; set; }

        /// <summary>
        /// 实例磁盘容量大小，单位：GB。该参数的设置步长为10。
        /// </summary>
        [JsonProperty("Storage")]
        public ulong? Storage{ get; set; }

        /// <summary>
        /// 购买实例数量，取值范围：[1-10]。一次性购买支持最大数量10个，若超过该数量，可进行多次调用进行购买。
        /// </summary>
        [JsonProperty("InstanceCount")]
        public ulong? InstanceCount{ get; set; }

        /// <summary>
        /// 购买时长，单位：月。
        /// <li>预付费：支持1,2,3,4,5,6,7,8,9,10,11,12,24,36</li>
        /// <li>后付费：只支持1</li>
        /// </summary>
        [JsonProperty("Period")]
        public ulong? Period{ get; set; }

        /// <summary>
        /// 实例字符集，目前只支持：
        /// <li> UTF8</li>
        /// <li> LATIN1</li>
        /// </summary>
        [JsonProperty("Charset")]
        public string Charset{ get; set; }

        /// <summary>
        /// 实例根账号用户名，具体规范如下：
        /// <li>用户名需要1-16个字符，只能由字母、数字或下划线组成</li>
        /// <li>不能为postgres</li>
        /// <li>不能由数字和pg_开头</li>
        /// <li>所有规则均不区分大小写</li>
        /// </summary>
        [JsonProperty("AdminName")]
        public string AdminName{ get; set; }

        /// <summary>
        /// 实例根账号用户名对应的密码，长度8 ~ 32位，推荐使用12位以上的密码;不能以" / "开头;
        /// 必须包含以下四项，字符种类:
        /// <li>小写字母： [a ~ z]</li>
        /// <li>大写字母：[A ～ Z]</li>
        /// <li>数字：0 - 9</li>
        /// <li>特殊字符：()`~!@#$%^&*-+=_|{}[]:;'<>,.?/</li>
        /// </summary>
        [JsonProperty("AdminPassword")]
        public string AdminPassword{ get; set; }

        /// <summary>
        /// PostgreSQL大版本号（该参数当前必传），版本信息可从[DescribeDBVersions](https://cloud.tencent.com/document/api/409/89018)获取。目前支持10，11，12，13，14，15这几个大版本，详情见[内核版本概述](https://cloud.tencent.com/document/product/409/67018)。
        /// 输入该参数时，会基于此大版本号创建对应的最新小版本的最新内核版本号实例。
        /// </summary>
        [JsonProperty("DBMajorVersion")]
        public string DBMajorVersion{ get; set; }

        /// <summary>
        /// PostgreSQL社区大版本+小版本号。
        /// 一般场景不推荐传入该参数。如需指定，只能传当前大版本号下最新小版本号。
        /// </summary>
        [JsonProperty("DBVersion")]
        public string DBVersion{ get; set; }

        /// <summary>
        /// PostgreSQL内核版本号。
        /// 一般场景不推荐传入该参数。如需指定，只能传当前大版本号下最新内核版本号。
        /// </summary>
        [JsonProperty("DBKernelVersion")]
        public string DBKernelVersion{ get; set; }

        /// <summary>
        /// 实例计费类型，目前支持：
        /// <li>PREPAID：预付费，即包年包月</li>
        /// <li>POSTPAID_BY_HOUR：后付费，即按量计费</li>
        /// 默认值：PREPAID
        /// </summary>
        [JsonProperty("InstanceChargeType")]
        public string InstanceChargeType{ get; set; }

        /// <summary>
        /// 私有网络ID，形如vpc-xxxxxxxx（该参数当前必传）。有效的VpcId可通过登录控制台查询；也可以调用接口 [DescribeVpcEx](https://cloud.tencent.com/document/api/215/1372) ，从接口返回中的unVpcId字段获取。
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// 私有网络子网ID，形如subnet-xxxxxxxx（该参数当前必传）。有效的私有网络子网ID可通过登录控制台查询；也可以调用接口 [DescribeSubnets ](https://cloud.tencent.com/document/api/215/15784)，从接口返回中的unSubnetId字段获取。
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// 实例节点部署信息，支持多可用区部署时需要指定每个节点的部署可用区信息。
        /// 可用区信息可以通过调用 [DescribeZones](https://cloud.tencent.com/document/api/409/16769) 接口的返回值中的Zone字段来获取。
        /// </summary>
        [JsonProperty("DBNodeSet")]
        public DBNode[] DBNodeSet{ get; set; }

        /// <summary>
        /// 续费标记：
        /// <li>0：手动续费</li>
        /// <li>1：自动续费</li>
        /// 默认值：0
        /// </summary>
        [JsonProperty("AutoRenewFlag")]
        public long? AutoRenewFlag{ get; set; }

        /// <summary>
        /// 是否自动使用代金券：
        /// <li>0：否</li>
        /// <li>1：是</li>
        /// 默认值：0
        /// </summary>
        [JsonProperty("AutoVoucher")]
        public ulong? AutoVoucher{ get; set; }

        /// <summary>
        /// 代金券ID列表，目前仅支持指定一张代金券。
        /// </summary>
        [JsonProperty("VoucherIds")]
        public string[] VoucherIds{ get; set; }

        /// <summary>
        /// 项目ID。默认取之为0，表示归属默认项目。
        /// </summary>
        [JsonProperty("ProjectId")]
        public long? ProjectId{ get; set; }

        /// <summary>
        /// 活动ID。
        /// </summary>
        [JsonProperty("ActivityId")]
        public long? ActivityId{ get; set; }

        /// <summary>
        /// 实例名称，仅支持长度小于60的中文/英文/数字/"_"/"-"，不指定实例名称则默认显示"未命名"。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 实例需要绑定的Tag信息，默认为空；可以通过调用 [DescribeTags](https://cloud.tencent.com/document/api/651/35316) 返回值中的 Tags 字段来获取。
        /// </summary>
        [JsonProperty("TagList")]
        public Tag[] TagList{ get; set; }

        /// <summary>
        /// 实例所属安全组，该参数可以通过调用 [DescribeSecurityGroups](https://cloud.tencent.com/document/api/215/15808) 的返回值中的sgId字段来获取。若不指定该参数，则绑定默认安全组。
        /// </summary>
        [JsonProperty("SecurityGroupIds")]
        public string[] SecurityGroupIds{ get; set; }

        /// <summary>
        /// 是否需要支持数据透明加密：
        /// <li>0：否</li>
        /// <li>1：是</li>
        /// 默认值：0
        /// 参考[数据透明加密概述](https://cloud.tencent.com/document/product/409/71748)
        /// </summary>
        [JsonProperty("NeedSupportTDE")]
        public ulong? NeedSupportTDE{ get; set; }

        /// <summary>
        /// 自定义密钥的KeyId，若选择自定义密匙加密，则需要传入自定义密匙的KeyId，KeyId是CMK的唯一标识。
        /// KeyId创建获取相关参考[开启透明数据加密](https://cloud.tencent.com/document/product/409/71749)
        /// </summary>
        [JsonProperty("KMSKeyId")]
        public string KMSKeyId{ get; set; }

        /// <summary>
        /// 使用KMS服务的地域，KMSRegion为空默认使用本地域的KMS，本地域不支持的情况下需自选其他KMS支持的地域。
        /// KMSRegion相关介绍参考[开启透明数据加密](https://cloud.tencent.com/document/product/409/71749)
        /// </summary>
        [JsonProperty("KMSRegion")]
        public string KMSRegion{ get; set; }

        /// <summary>
        /// 指定KMS服务的集群，KMSClusterId为空使用默认集群的KMS，若选择指定KMS集群，则需要传入KMSClusterId。 KMSClusterId相关介绍参考开启透明数据加密
        /// </summary>
        [JsonProperty("KMSClusterId")]
        public string KMSClusterId{ get; set; }

        /// <summary>
        /// 数据库引擎，支持：
        /// <li>postgresql：云数据库PostgreSQL</li>
        /// <li>mssql_compatible：MSSQL兼容-云数据库PostgreSQL</li>
        /// 默认值：postgresql
        /// </summary>
        [JsonProperty("DBEngine")]
        public string DBEngine{ get; set; }

        /// <summary>
        /// 数据库引擎的配置信息，配置格式如下：
        /// {"$key1":"$value1", "$key2":"$value2"}
        /// 各引擎支持如下：
        /// mssql_compatible引擎：
        /// <li>migrationMode：数据库模式，可选参数，可取值：single-db（单数据库模式），multi-db（多数据库模式）。默认为single-db。</li>
        /// <li>defaultLocale：排序区域规则，可选参数，在初始化后不可修改，默认为en_US，可选值如下：
        /// "af_ZA", "sq_AL", "ar_DZ", "ar_BH", "ar_EG", "ar_IQ", "ar_JO", "ar_KW", "ar_LB", "ar_LY", "ar_MA", "ar_OM", "ar_QA", "ar_SA", "ar_SY", "ar_TN", "ar_AE", "ar_YE", "hy_AM", "az_Cyrl_AZ", "az_Latn_AZ", "eu_ES", "be_BY", "bg_BG", "ca_ES", "zh_HK", "zh_MO", "zh_CN", "zh_SG", "zh_TW", "hr_HR", "cs_CZ", "da_DK", "nl_BE", "nl_NL", "en_AU", "en_BZ", "en_CA", "en_IE", "en_JM", "en_NZ", "en_PH", "en_ZA", "en_TT", "en_GB", "en_US", "en_ZW", "et_EE", "fo_FO", "fa_IR", "fi_FI", "fr_BE", "fr_CA", "fr_FR", "fr_LU", "fr_MC", "fr_CH", "mk_MK", "ka_GE", "de_AT", "de_DE", "de_LI", "de_LU", "de_CH", "el_GR", "gu_IN", "he_IL", "hi_IN", "hu_HU", "is_IS", "id_ID", "it_IT", "it_CH", "ja_JP", "kn_IN", "kok_IN", "ko_KR", "ky_KG", "lv_LV", "lt_LT", "ms_BN", "ms_MY", "mr_IN", "mn_MN", "nb_NO", "nn_NO", "pl_PL", "pt_BR", "pt_PT", "pa_IN", "ro_RO", "ru_RU", "sa_IN", "sr_Cyrl_RS", "sr_Latn_RS", "sk_SK", "sl_SI", "es_AR", "es_BO", "es_CL", "es_CO", "es_CR", "es_DO", "es_EC", "es_SV", "es_GT", "es_HN", "es_MX", "es_NI", "es_PA", "es_PY","es_PE", "es_PR", "es_ES", "es_TRADITIONAL", "es_UY", "es_VE", "sw_KE", "sv_FI", "sv_SE", "tt_RU", "te_IN", "th_TH", "tr_TR", "uk_UA", "ur_IN", "ur_PK", "uz_Cyrl_UZ", "uz_Latn_UZ", "vi_VN"。</li>
        /// <li>serverCollationName：排序规则名称，可选参数，在初始化后不可修改，默认为sql_latin1_general_cp1_ci_as，可选值如下："bbf_unicode_general_ci_as", "bbf_unicode_cp1_ci_as", "bbf_unicode_CP1250_ci_as", "bbf_unicode_CP1251_ci_as", "bbf_unicode_cp1253_ci_as", "bbf_unicode_cp1254_ci_as", "bbf_unicode_cp1255_ci_as", "bbf_unicode_cp1256_ci_as", "bbf_unicode_cp1257_ci_as", "bbf_unicode_cp1258_ci_as", "bbf_unicode_cp874_ci_as", "sql_latin1_general_cp1250_ci_as", "sql_latin1_general_cp1251_ci_as", "sql_latin1_general_cp1_ci_as", "sql_latin1_general_cp1253_ci_as", "sql_latin1_general_cp1254_ci_as", "sql_latin1_general_cp1255_ci_as","sql_latin1_general_cp1256_ci_as", "sql_latin1_general_cp1257_ci_as", "sql_latin1_general_cp1258_ci_as", "chinese_prc_ci_as", "cyrillic_general_ci_as", "finnish_swedish_ci_as", "french_ci_as", "japanese_ci_as", "korean_wansung_ci_as", "latin1_general_ci_as", "modern_spanish_ci_as", "polish_ci_as", "thai_ci_as", "traditional_spanish_ci_as", "turkish_ci_as", "ukrainian_ci_as", "vietnamese_ci_as"。</li>
        /// </summary>
        [JsonProperty("DBEngineConfig")]
        public string DBEngineConfig{ get; set; }

        /// <summary>
        /// 主从同步方式，支持： 
        /// <li>Semi-sync：半同步</li>
        /// <li>Async：异步</li>
        /// 主实例默认值：Semi-sync
        /// 只读实例默认值：Async
        /// </summary>
        [JsonProperty("SyncMode")]
        public string SyncMode{ get; set; }

        /// <summary>
        /// 是否需要支持Ipv6：
        /// <li>0：否</li>
        /// <li>1：是</li>
        /// 默认值：0
        /// </summary>
        [JsonProperty("NeedSupportIpv6")]
        public ulong? NeedSupportIpv6{ get; set; }

        /// <summary>
        /// 实例是否开启删除保护: true-开启删除保护；false-关闭删除保护。
        /// </summary>
        [JsonProperty("DeletionProtection")]
        public bool? DeletionProtection{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamSimple(map, prefix + "SpecCode", this.SpecCode);
            this.SetParamSimple(map, prefix + "Storage", this.Storage);
            this.SetParamSimple(map, prefix + "InstanceCount", this.InstanceCount);
            this.SetParamSimple(map, prefix + "Period", this.Period);
            this.SetParamSimple(map, prefix + "Charset", this.Charset);
            this.SetParamSimple(map, prefix + "AdminName", this.AdminName);
            this.SetParamSimple(map, prefix + "AdminPassword", this.AdminPassword);
            this.SetParamSimple(map, prefix + "DBMajorVersion", this.DBMajorVersion);
            this.SetParamSimple(map, prefix + "DBVersion", this.DBVersion);
            this.SetParamSimple(map, prefix + "DBKernelVersion", this.DBKernelVersion);
            this.SetParamSimple(map, prefix + "InstanceChargeType", this.InstanceChargeType);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamArrayObj(map, prefix + "DBNodeSet.", this.DBNodeSet);
            this.SetParamSimple(map, prefix + "AutoRenewFlag", this.AutoRenewFlag);
            this.SetParamSimple(map, prefix + "AutoVoucher", this.AutoVoucher);
            this.SetParamArraySimple(map, prefix + "VoucherIds.", this.VoucherIds);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "ActivityId", this.ActivityId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamArrayObj(map, prefix + "TagList.", this.TagList);
            this.SetParamArraySimple(map, prefix + "SecurityGroupIds.", this.SecurityGroupIds);
            this.SetParamSimple(map, prefix + "NeedSupportTDE", this.NeedSupportTDE);
            this.SetParamSimple(map, prefix + "KMSKeyId", this.KMSKeyId);
            this.SetParamSimple(map, prefix + "KMSRegion", this.KMSRegion);
            this.SetParamSimple(map, prefix + "KMSClusterId", this.KMSClusterId);
            this.SetParamSimple(map, prefix + "DBEngine", this.DBEngine);
            this.SetParamSimple(map, prefix + "DBEngineConfig", this.DBEngineConfig);
            this.SetParamSimple(map, prefix + "SyncMode", this.SyncMode);
            this.SetParamSimple(map, prefix + "NeedSupportIpv6", this.NeedSupportIpv6);
            this.SetParamSimple(map, prefix + "DeletionProtection", this.DeletionProtection);
        }
    }
}

